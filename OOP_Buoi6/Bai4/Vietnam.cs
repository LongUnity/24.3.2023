using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Vietnam:Khachhang
    {
        public string DoituongKH { get; set; }
        public int Dinhmuc { get; set; }
        public Vietnam() { }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập đối tượng khách(Sinh hoạt, Sản xuất, Kinh doanh): ");
            DoituongKH = Console.ReadLine();
            Console.WriteLine("Nhập định mức: ");
            Dinhmuc = int.Parse(Console.ReadLine());
        }        
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("Đối tượng khách: " + DoituongKH);
            Console.WriteLine("Định mức tiêu thụ: " + Dinhmuc);
        }
        public double Tiendien()
        {
            if (SoDienTieuThu >= Dinhmuc)
            {
                return (Dinhmuc*Dongia)+((SoDienTieuThu - Dinhmuc) * Dongia * 2.5);
            }
            else
            {
                return SoDienTieuThu * Dongia;
            }
        }
    }
}
