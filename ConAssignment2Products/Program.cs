using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignment2Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HerbalProduct product = new HerbalProduct();
            product.Set();
            product.Show();
            Console.ReadKey();
        }
    }
}
