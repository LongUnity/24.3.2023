using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class main
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            DSKH dSKH = new DSKH();

            dSKH.nhap();
            dSKH.xuat();



            Console.ReadKey();
        }
    }
}
