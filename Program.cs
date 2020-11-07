using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema_1();
            //Problema_2();
            //Problema_3();
            //Problema_4();
            //Problema_5();
            //Problema_6();
        }

        private static void Problema_6()
        {
            throw new NotImplementedException();
        }

        private static void Problema_5()
        {
            throw new NotImplementedException();
        }

        private static void Problema_4()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculati suma si produsul numerelor de la 1 la n. 
        /// </summary>
        private static void Problema_3()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int suma = 0; int produs = 1;
            
            for (int i = 1; i <= n; i++)
            {
                suma = suma + i;
                produs = produs * i;
            }

            Console.WriteLine($"Suma si produsul numerelor de la 1 la {n} sunt {suma} si, respectiv, {produs}.");


        }

        /// <summary>
        /// Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
        /// </summary>
        private static void Problema_2()
        {
            Console.WriteLine("Cate numere doriti sa introduceti?");
            int n = int.Parse(Console.ReadLine());
            int negative = 0; int pozitive = 0; int zero = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i}");
                int numar = int.Parse(Console.ReadLine());
                if (numar < 0)
                {
                    negative += 1;
                }
                if (numar > 0)
                {
                    pozitive += 1;
                }
                if (numar == 0)
                {
                    zero += 1;
                }
            }

            Console.WriteLine($"Ati introdus {zero} zerouri, {negative} numere negative si {pozitive} numere pozitive.");

        }



        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
        /// </summary>
        private static void Problema_1()
        {
            Console.WriteLine("Cate numere doriti sa introduceti?");
            int n = int.Parse(Console.ReadLine());
            int paritate = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i}");
                int numar = int.Parse(Console.ReadLine());
                if (numar % 2 == 0)
                {
                    paritate += 1;
                }
            }

            Console.WriteLine($"Ati introdus {paritate} numere pare.");
        }
    }
}
