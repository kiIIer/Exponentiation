using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentiationlApp
{
    class Program
    {
        static void Main()
        {
            var program = new Program();

            while (true)
            {
                Console.WriteLine("To exit enter 'x'.");
                Console.WriteLine("Please provide ordinal of a Exponentiation number:");

                var ExponentiationText = Console.ReadLine();

                if (ExponentiationText == "x") return;

                if (ExponentiationText == "hi") Console.WriteLine("Hello. This secret was made by Michael!");

                if (ExponentiationText == "hi") continue;

                if (!ulong.TryParse(ExponentiationText, out ulong Exponentiation))
                {
                    Console.WriteLine("Entered value is not a number!");
                    continue;
                }

                try
                {
                    var exponentiationNumber = program.GetExponentiationNumber(Exponentiation);

                    Console.WriteLine("Exponentiation({0:N0}) = {1:N0}", Exponentiation, exponentiationNumber);
                }
                catch (Exception exception)
                {
                    Console.WriteLine($"An error occured: {exception.Message}");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

        }

        ulong GetExponentiationNumber(ulong Exponentiation)
        {
            if (Exponentiation == 0) return 0;
            else return Exponentiation * Exponentiation;
                   
        }

    }
}
