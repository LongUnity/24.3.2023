using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Hocvien:Nguoi
    {
        public string Malop { get; set; }

        public void nhap()
        {
            base.nhap();

            Console.WriteLine("Nhap ten:");
            Malop = Console.ReadLine();
        }
        public void xuat()
        {
            base.xuat();
            Console.WriteLine("Ma Lop: " + Malop);
        }
    }
}
