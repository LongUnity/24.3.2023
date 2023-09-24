using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Khachhang
    {
        public int MaKH { get; set; }    
        public string Hoten { get; set; }
        public string NgaylapHD { get; set; }
        public int SoDienTieuThu { get; set; }
        public int Dongia { get; set; }
        public Khachhang() { }

        public void nhap()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            MaKH = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập Ho va ten: ");
            Hoten = Console.ReadLine();
            Console.WriteLine("Nhập ngay tao don: ");
            NgaylapHD = Console.ReadLine();
            Console.WriteLine("Nhập so dien tieu thu: ");
            SoDienTieuThu = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập don gia: ");
            Dongia = int.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("Thong tin khach hang");
            Console.WriteLine("Mã khách hàng: "+ MaKH);            
            Console.WriteLine("Ho va ten: "+ Hoten);
            Console.WriteLine("Ngay tao don: "+ NgaylapHD);
            Console.WriteLine("Do dien tieu thu: "+ SoDienTieuThu);
            Console.WriteLine("Don gia: "+ Dongia);
        }

    }
}
