using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*HinhElip he = new HinhElip();

            he.nhap();
            he.xuat();
            Console.WriteLine("Chu vi: "+he.ChuVi+", Dien tich: "+he.DienTich);*/

            HinhTron ht = new HinhTron();

            ht.nhap();
            ht.xuat();
            Console.WriteLine("Chu vi: " + ht.ChuVi + ", Dien tich: " + ht.DienTich);

            Console.ReadKey();
        }
    }
}
