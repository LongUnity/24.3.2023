using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhElip
    {
        public float BT1 { get; set; }
        public float BT2 { get; set; }
        public double pi = 3.14;
        public double ChuVi => 2 * pi * Math.Sqrt((Math.Pow(BT1,2) + Math.Pow(BT2, 2)) /2);
        public double DienTich => pi*BT1*BT2;
        public HinhElip() { }

        public void nhap()
        {
            Console.WriteLine("Nhập chiều dài trục 1: ");
            BT1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều dài trục 2: ");
            BT2 = float.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Chiều dài trục 1: "+BT1);
            Console.WriteLine("Chiều dài trục 2: "+BT2);
        }
    }
}
