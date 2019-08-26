using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0xA2Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;

            Console.Write("Bitte antworten Sie!!!");
            c = Console.ReadKey().KeyChar;
            c = char.ToLower(c);

            Console.WriteLine();

            switch (c)
            {
                case 'j':
                case 'o':
                case 'y':
                    Console.WriteLine("Sie haben mit 'Ja' geantwortet");
                    break;

                case 'n':
                    Console.WriteLine("Sie haben mit 'Nein' geantwortet");
                    break;

                default:
                    Console.WriteLine("Sie haben eine falsche Eingabe gemacht");
                    break;
            }

        }
    }
}
