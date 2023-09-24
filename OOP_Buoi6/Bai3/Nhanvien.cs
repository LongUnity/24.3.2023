using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Nhanvien
    {
        public string Hoten { get; set; }
        public int Tuoi { get; set; }
        public int Songaycong { get; set; }
        public int Luongcoban { get; set; }

        public Nhanvien() { }

        public void nhap()
        {            
            Console.WriteLine("Nhập Ho va ten: ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhập tuoi: ");
            Tuoi =int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập So ngay cong: ");
            Songaycong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Luong co ban: ");
            Luongcoban = int.Parse(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("Thong tin nhan vien da nhap: ");
            Console.WriteLine("Ho va ten: "+Hoten);
            Console.WriteLine("Tuoi: "+Tuoi);
            Console.WriteLine("So ngay cong: "+Songaycong);
            Console.WriteLine("Luong co ban: "+Luongcoban);
        }
        public int Luongchinh()
        {
            Console.WriteLine("Luong nhan vien: "+ (Luongcoban * Songaycong));
            return (Luongcoban * Songaycong);
        }
    }
}
