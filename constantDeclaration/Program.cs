using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constantDeclaration
{
    class Program
    {
        static void Main(string[] args)
        {

            const double PI = 3.14952;

           
            Console.WriteLine("Enter value of Radius");
            double r = Convert.ToDouble(Console.ReadLine());
            Double AreaCircle = PI* r * r;
            Console.WriteLine("Radius: {0},AreaCircle is: {1},PI: {2}", r, AreaCircle, PI);
            Console.ReadLine();
        }
    }
}
