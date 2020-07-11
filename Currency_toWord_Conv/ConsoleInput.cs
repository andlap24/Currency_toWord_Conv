using System;
using System.Threading;

namespace Currency_toWord_Conv
{
    class ConsoleInput
    {
        public void GetNumber()
        {
            Conventer convert = new Conventer();

            string answer = "N";
            do
            {
                Console.Write("Enter a number: ");
                double numInput = double.Parse(Console.ReadLine());
                Console.WriteLine(convert.changeCurrencyToWords(numInput));

                Console.WriteLine("Press <Y> to try again, or <N> to exit...");
                answer = Console.ReadLine().ToUpper();
            }
            while (answer == "Y");

            if (answer == "N")
            {
                Console.WriteLine("The app close after 3 seconds...");
                Thread.Sleep(3000);
            }
        }
    }
}
