using System;

namespace Cs_intro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");

            // String Variable
            string innovations = "Never Stop Creating";

            // Number Variables
            int num1 = 95;
            float num2 = 95.775f;
            double num3 = 95.755;

            // Boolean Variable
            bool boolean = true;

            Console.WriteLine(innovations);
            Console.WriteLine(num2);
            Console.WriteLine(boolean);

            // Press key to continue
            Console.ReadKey();

            // Concatenation
            string concat1 = "Be" + " " + "Brilliant";
            string concat2 = "Be" + " " + "Bright";

            // Math
            float out1 = 9.9f * 30f;
            float out2 = 4.5f * 15f;

            //Constants
            const string myName = "Ianette";
                const bool arrow = true;

            // String interpolation
            Console.WriteLine("myName is {0}. Num: {1}, Num: {2}.", myName, num1, out2);
        }
    }
}
