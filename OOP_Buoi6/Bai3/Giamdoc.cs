using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Giamdoc : Truongphong
    {
        public int Thamnien { get; set; }

        public Giamdoc() { }
        public void nhap()
        {
            base.nhap();
            Console.Write("Nhập tham nien lam viec: ");
            Thamnien = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            base.xuat();
        }
        public int Luongchinh(){            
            if (Thamnien >= 10) {
                Console.Write("Luong giam doc tham niem tren 10 nam: " + (30000000 + Phucap + 10000000));
                return 30000000 + Phucap + 10000000;                
            }
            else
            {
                Console.Write("Luong giam doc tham niem duoi 10 nam: " + (30000000 + Phucap + 3000000));
                return 30000000 + Phucap + 3000000;
                
            }
         }
    }
}
