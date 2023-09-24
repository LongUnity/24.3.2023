using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Hv:Hcn
    {
        //public double ChuVi => A * 4;
        //public double DienTich => A * B;
        public Hv() { }
        public void nhap()
        {
            Console.Write("Nhập cạnh: ");
            A = double.Parse(Console.ReadLine());
            B = A;
        }
    }
}
