using System;
using System.Globalization;
using System.Text;

namespace CoSoLapTrinh.session03
{
    internal class ex01
    {
        static void Bai01()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhap chi so dien cu (kWh): ");
            decimal csd_cu = decimal.Parse(Console.ReadLine());

            Console.Write("Nhap chi so dien moi (kWh): ");
            decimal csd_moi = decimal.Parse(Console.ReadLine());

            // 1. Kiểm tra điều kiện chỉ số
            if (csd_moi < csd_cu)
            {
                Console.WriteLine("Loi: Chi so moi phai lon hon hoac bang chi so cu!");
                return;
            }

            decimal so_dien = csd_moi - csd_cu;
            decimal tiendien = 0;

            // 2. Tính tiền điện theo bậc thang (Đơn giá: 1806, 1866, 2167, 2729, 3050)
            if (so_dien <= 50)
            {
                tiendien = so_dien * 1806m;
            }
            else if (so_dien <= 100)
            {
                tiendien = 50 * 1806m + (so_dien - 50) * 1866m;
            }
            else if (so_dien <= 200)
            {
                tiendien = 50 * 1806m + 50 * 1866m + (so_dien - 100) * 2167m;
            }
            else if (so_dien <= 300)
            {
                tiendien = 50 * 1806m + 50 * 1866m + 100 * 2167m + (so_dien - 200) * 2729m;
            }
            else
            {
                tiendien = 50 * 1806m + 50 * 1866m + 100 * 2167m + 100 * 2729m + (so_dien - 300) * 3050m;
            }

            decimal thueVAT = tiendien * 0.08m;
            decimal tongThanhToan = tiendien + thueVAT;

            // 3. In kết quả chuẩn định dạng phân cách hàng nghìn
            CultureInfo cul = new CultureInfo("vi-VN");
            Console.WriteLine($"\nSo dien tieu thu: {so_dien} kWh");
            Console.WriteLine($"Tien dien chua thue: {tiendien:N0)} VNĐ");
            Console.WriteLine($"Thue VAT (8%): {thueVAT} VNĐ");
            Console.WriteLine($"Tong thanh toan: {tongThanhToan} VNĐ");
        }

        public static void Main(string[] args)
        {
            Bai01();
        }
    }
}