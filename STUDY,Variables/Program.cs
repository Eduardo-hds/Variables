using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables \n");

            string text;

            text = "Varialbes in action.";

            Console.WriteLine("string strores texts: {0} \n", text);

            int number = 12;

            Console.WriteLine("int stores whole number: {0} \n", number);

            double number2 = 12.94;
            

            Console.WriteLine("double stores fractional numbers: {0} \n", number2);

            bool isTrue = false;

            Console.WriteLine("bool stores boolean results: {0} \n", isTrue);

            Console.ReadKey();

        }
    }
}
