using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int n;
            Console.WriteLine("1: thêm nhân viên");
            Console.WriteLine("2: thêm trưởng phòng:");
            Console.WriteLine("3: thêm giám đốc:");
            Console.WriteLine("số khác: Thoát!!!");
            Console.Write("Nhập lựa chọn: ");
            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Mời thêm nhân viên:");
                    Nhanvien nhanvien = new Nhanvien();
                    nhanvien.nhap();
                    nhanvien.xuat();
                    nhanvien.Luongchinh();
                    break;
                case 2:
                    Console.WriteLine("Mời thêm trưởng phòng:");
                    Truongphong truongphong = new Truongphong();
                    truongphong.nhap();
                    truongphong.xuat();
                    truongphong.Luongchinh();
                    break;
                case 3:
                    Console.WriteLine("Mời thêm giám đốc:");
                    Giamdoc giamdoc =new Giamdoc();
                    giamdoc.nhap();
                    giamdoc.xuat();
                    giamdoc.Luongchinh();
                    break;                
                default:
                    Console.WriteLine("Thoát chương trình");
                    break;
            }

            Console.ReadKey();
        }
    }
}
