using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Nguoi
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Nguoi() { }

        public void nhap()
        {
            Console.WriteLine("Nhap ten:");
            Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi:");
            Age = int.Parse(Console.ReadLine());
        }
        public void xuat() 
        {
            Console.WriteLine($"Ten: {Name}, Tuoi: {Age}");
        }
    }
}
