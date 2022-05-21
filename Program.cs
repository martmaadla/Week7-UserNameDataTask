using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada nr 1-3;
            //kui kasutaja sisestab `1`, siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja valib `2`, siis kuvatakse kasutaja eesnimi esimene täht;
            //kui kasutaja valib `3`, siis kuvatakse kasutaja eesnime pikkus;

            Console.WriteLine("Palun sisestage oma nimi");
            string name = Console.ReadLine();
            Console.WriteLine("Palun sisestage arv ühest kolmeni");
            
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    nameReverse(name);
                    break;
                case 2:
                    nameFirstLetter(name);
                    break;
                case 3:
                    nameLenght(name);
                    break;
                default:
                    Console.WriteLine("Vale arv");
                    break;
            }
            Console.ReadLine();
        }

        private static void nameReverse(string name)
        {
            Console.WriteLine("Sinu nimi tagurpidi on ");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
        }

        private static void nameFirstLetter(string name)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {name[0]}");
        }

        private static void nameLenght(string name)
        {
            Console.WriteLine($"Sinu nimi on {name.Length} sümbolit pikk");
        }
    }
}
