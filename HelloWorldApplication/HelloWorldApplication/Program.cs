using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.ReadLine();

            //implicit conversion
            int firstVal = 6;
            int secondVal = 50;
            long total;

            // In this the int values are implicitly converted to long data type;
            //you need not to tell compiler to do the conversion, it automatically does.
            total = firstVal + secondVal;

            Console.WriteLine("Total is : " + total);
            Console.ReadLine();



            // explicit conversion
            int firstNum = 65;
            char alpha;
            alpha = (char)firstNum;

            // In this the int values are explicitly converted to char data type;
            //you have to tell compiler to do the conversion, it uses casting.
            Console.WriteLine("alphabet is: " + alpha);
            Console.ReadLine();



            //C# built-in type conversion methods
            int    firstInt = 21;
            float  firstFloat = 13.008f;
            double firstDouble = 6758.2018;
            bool   firstBoolean = true;

            Console.WriteLine(firstInt.ToString());
            Console.WriteLine(firstFloat.ToString());
            Console.WriteLine(firstDouble.ToString());
            Console.WriteLine(firstBoolean.ToString());

            Console.ReadLine();

        }
    }
}
