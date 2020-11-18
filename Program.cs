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
            //Problema_7();
            //Problema_8();
            //Problema_9(); 
            //Problema_10();
            

        }


        /// <summary>
        /// Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
        /// </summary>
        private static void Problema_10()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int numar = 0, max = 0, contor = 1, previous_number; //variabila contor va tine cont de cate numere egale sunt consecutive intr-o serie de numere egale consecutive.

            for (int i = 1; i <= n; i++)
            {
                previous_number = numar; 
                Console.WriteLine($"Introduceti numarul {i}");
                numar = int.Parse(Console.ReadLine());
                if (previous_number == numar && i > 1) //daca numarul de dinainte este egal cu numarul actual SI nu suntem la prima repetare.
                
                    contor++;
                
                else
                
                    contor = 1; // oricand se gasesc doua numere care nu sunt egale si consecutive, contorul trece la 1.
                
                if (max < contor)
                
                    max = contor;
            }

            if (max == 1)
            {
                Console.WriteLine("NU exista numere consecutive egale in secventa.");
            }
            else
            {
                Console.WriteLine($"Exista maxim {max} numere consecutive egale in secventa.");
            }

        }





        /// <summary>
        /// Sa se determine daca o secventa de n numere este monotona. 
        /// Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
        /// </summary>
        private static void Problema_9()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int numar = 0, previous_number;
            bool monotona = true;
            int monotonie_curenta = -2, monotonie_trecuta;


            for (int i = 1; i <= n; i++)
            {
                monotonie_trecuta = monotonie_curenta;
                previous_number = numar;
                Console.WriteLine($"Introduceti numarul {i}");
                numar = int.Parse(Console.ReadLine());

                if (i > 1)
                {
                    if (numar - previous_number >= 0)
                    {
                        monotonie_curenta = 1;  //1 pentru sir crescator
                    }
                    else
                    {
                        monotonie_curenta = 0;  //0 pentru sir descrescator
                    }
                }

                if (monotonie_curenta != monotonie_trecuta && i > 2) //monotonia se poate schimba doar atunci cand avem mai mult de 2 numere in sir (deoarece oricare sir de doua numere este monoton, fie descrescator fie crescator)
                {
                    monotona = false;
                }
            }
            if (monotona == true)
            {
                Console.WriteLine("Secventa este monotona. ");
            }
            else
            {
                Console.WriteLine("Secventa NU este monotona. ");
            }

        }



        /// <summary>
        /// Determianti al n-lea numar din sirul lui Fibonacci. 
        /// Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). 
        /// Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
        /// </summary>
        private static void Problema_8()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());

            int numar1 = 0; int numar2 = 1; int numar = 0;

            for (int i = 2; i < n; i++)
            {
                numar = numar1 + numar2;
                numar1 = numar2;
                numar2 = numar;
            }

            Console.WriteLine(numar);


        }



        /// <summary>
        /// Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.
        /// </summary>
        private static void Problema_7()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int max = 0; int min = 0; int numar;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i}");
                numar = int.Parse(Console.ReadLine());

                if (max < numar)
                {
                    max = numar;
                }
                if (min > numar)
                {
                    min = numar;
                }

            }

            Console.WriteLine($"Cea mai mare si cea mai mica valoare din secventa sunt {max}, respectiv {min}.");


        }


        /// <summary>
        /// Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.
        /// </summary>
        private static void Problema_6()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int numar=0, aux;
            bool crescatoare = true;

            for (int i = 1; i <= n; i++)
            {
                aux = numar;
                Console.WriteLine($"Introduceti numarul {i}");
                numar = int.Parse(Console.ReadLine());
                if (numar < aux)
                    crescatoare = false;                 
            }

            if (crescatoare == false)
            {
                Console.WriteLine("Numerele nu sunt in ordine crescatoare.");
            }
            else
            {
                Console.WriteLine("Numerele sunt in ordine crescatoare");
            }

        }


        /// <summary>
        /// Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa? 
        /// Se considera ca primul element din secventa este pe pozitia 0.
        /// </summary>
        private static void Problema_5()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            int contor = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i}.");
                int numar = int.Parse(Console.ReadLine());
                if (numar == i)
                {
                    contor += 1;
                }
            }
            Console.WriteLine($"{contor} numere sunt egale cu pozitia pe care apar in secventa");
        }

        /// <summary>
        /// Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. 
        /// Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
        /// </summary>

        private static void Problema_4()
        {
            Console.WriteLine("Introduceti numarul n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul a");
            int a = int.Parse(Console.ReadLine());
            int contor = -1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i}");
                int numar = int.Parse(Console.ReadLine());
                if (numar == a)
                {
                    contor = i;
                }
            }
            if (contor != -1)
            {
                Console.WriteLine($"Pozitia pe care se afla elementul {a} este {contor}");
            }
            else
            {
                Console.WriteLine(contor);
            }
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
        /// Se da o secventa de n numere. Sa se determine cate sunt negative, cate sunt zero si cate sunt pozitive. 
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
