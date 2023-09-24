using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Hcn
    {
        public double A { get; set; }
        public double B { get; set; }
        public double ChuVi => (A + B) * 2;
        public double DienTich => A * B;
        public Hcn() { }
        public void nhap()
        {
            Console.Write("Nhập chiều dài: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            B = double.Parse(Console.ReadLine());
        }
    }
}
