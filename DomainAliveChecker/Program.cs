using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAliveChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập mail tại file combo.txt sau đó nhấn Enter để tiếp tục !!");
            Console.Write("Nhập số luồng chạy : ");
            int threads = Convert.ToInt32(Console.ReadLine());
        }
        private void InitChecking()
        {

        }
    }
}
