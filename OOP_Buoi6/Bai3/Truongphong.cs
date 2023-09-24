using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Truongphong:Nhanvien
    {
        public int Phucap { get; set; }

        

        public Truongphong() { }

        public void nhap()
        {
            base.nhap();
            Console.Write("Nhập phu cap: ");
            Phucap = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            base.xuat();
        }
        public int Luongchinh()
        {
            Console.Write("Luong truong phong: "+ (Luongcoban * Songaycong) + Phucap);
            return (Luongcoban * Songaycong) + Phucap;
        }
    }
}
