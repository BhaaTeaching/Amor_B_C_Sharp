using System;

namespace Amor_Bsoul
{
    class Program
    {
        static void Main(string[] args)
        {
            //كتب برنامج يستقبل  محيط مربع بال cm, يحسب ويطبع طول ضلعه بال cm.
            double p;
            Console.WriteLine(" Enter P in cm : ");
            p = double.Parse(Console.ReadLine());
            double a = p / 4;
            Console.WriteLine("The lenght of the edge in CM = {0}", a);
            //--------------------------------------------------------------------------------

            //اكتب برنامج يستقبل عدد مكون من 3 منازل ويطبع مجموع منازله
            // مثال: 352َ --> 3 + 5 + 2 = 10.

            int number;
            int x, y, z;

            Console.WriteLine("Enter number with 3 digits : ");
            number = int.Parse(Console.ReadLine());

            x = number % 10; // 2
            y = (number % 100) / 10; // 5
            z = number / 100; // 3

            int sumOfDigits = x + y + z;
            Console.WriteLine("The sum of digits of the number = " + sumOfDigits);

        }
    }
}
