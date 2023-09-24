using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*Hcn hcn = new Hcn();
            hcn.nhap();
            Console.WriteLine("Chu vi hcn: "+hcn.ChuVi+" Dien tich hcn: "+hcn.DienTich);*/


            Hv hv = new Hv();
            hv.nhap();
            Console.WriteLine("Chu vi hv: " + hv.ChuVi + " Dien tich hcn: " + hv.DienTich);


            Console.ReadKey();
        }
    }
}
