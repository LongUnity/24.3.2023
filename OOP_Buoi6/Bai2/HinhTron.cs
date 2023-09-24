using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HinhTron:HinhElip
    {
        public HinhTron() { }

        public void nhap()
        {
            Console.WriteLine("Nhập bán kính: ");
            BT1 = float.Parse(Console.ReadLine());
            BT2 = BT1;
        }
        public void xuat()
        {
            Console.WriteLine("Bán kính: "+BT1);
            
        }
    }
}
