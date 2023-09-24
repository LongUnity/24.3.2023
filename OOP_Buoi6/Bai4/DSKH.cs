using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class DSKH
    {
        public int n { get; set; }
        public ArrayList dskh {  get; set; }
        public DSKH() { }

        public void nhap()
        {
            dskh = new ArrayList();
            Console.WriteLine("Nhập số lượng khách hàng: ");
            this.n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m;
                Console.WriteLine("1: thêm khách hàng việt nam");
                Console.WriteLine("2: thêm khách hàng nước ngoài:");
                Console.WriteLine("số khác: Thoát!!!");
                Console.Write("Nhập lựa chọn: ");
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine("Mời thêm KH Việt Nam:");
                        Vietnam vn = new Vietnam();
                        vn.nhap();
                        dskh.Add(vn);
                        break;
                    case 2:
                        Console.WriteLine("Mời thêm KH nước ngoài:");
                        Nuocngoai nn = new Nuocngoai();
                        nn.nhap();
                        dskh.Add(nn);
                        break;                    
                    default:
                        Console.WriteLine("Thoát chương trình");
                        break;
                }                

                Console.WriteLine();
            }
        }
        public void xuat()
        {

            foreach (var item in dskh)
            {
                ((Khachhang)item).xuat();
            }
        }
        //Tính tổng tiền danh sách khách hàng viet nam
        //Cho biết khách hàng nào đóng tiền nhiều nhất

    }
}
