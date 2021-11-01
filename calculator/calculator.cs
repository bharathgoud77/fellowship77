using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caluclator
{
    class Program
    {
        static void Main(string[] args)

        {
            int total;
            public int getSum(int num1, int num2)
            {
                return total = num1 + num2;
            }
            public int getDiv(int num1, int num2)
            {
                return total = num1 / num2;
            }
            public int getMul(int num1, int num2)
            {
                return total = num1 * num2;
            }
            public int getSub(int num1, int num2)
                return total = num1 - num2;

        }
    }
}
namespace Caluclator
{ 
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator objCalculator = new Calculator();
            Console.WriteLine("total Values =" + objCalculator.isSum(30, 20));
            Console.WriteLine("total Values =" + objCalculator.isDiv(30, 20));
            Console.WriteLine("total Values =" + objCalculator.isMul(30, 20));
            Console.WriteLine("total Values =" + objCalculator.isSub(30, 20));
            Console.ReadKey();
        }
    }
