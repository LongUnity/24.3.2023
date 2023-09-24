using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Nuocngoai:Khachhang
    {
        public string Quoctich {get;set;}
        
        public Nuocngoai() { }

        public void nhap()
        {
            base.nhap();
            Console.WriteLine("Nhập Quốc Tịch: ");
            Quoctich = Console.ReadLine();
        }
        public double Tiendien => SoDienTieuThu * Dongia * 2.5;
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("Quốc Tịch" + Quoctich);
        }
    }
}
