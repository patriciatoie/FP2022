using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FP_Set1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Introduceti un numar cuprins intre 1 si 21 corespunzator problemei:");
            nr = int.Parse(Console.ReadLine());

            switch (nr)
            {
                case 1: P1();break;
                case 2: P2();break;
                case 3: P3();break;
                case 4: P4();break;
                case 5: P5();break;
                case 6: P6();break;
                case 7: P7();break;
                case 8: P8();break;
                case 9: P9();break;
                case 10: P10();break;
                case 11: P11();break;
                case 12: P12();break;
                case 13: P13();break;
                case 14: P14();break;
                case 15: P15();break;
                case 16: P16();break;
                case 17:P17(); break;
                case 18: P18();break;
                case 19: P19();break;
                case 20:P20();break;
                case 21:P21();break;
                default:
                    Console.WriteLine("Numarul introdus nu este corect, numarul trebuie sa fie cuprins intre 1 si 21, conform problemei.");
                    break;
            }
        }

        private static void P1()
        {
            /* Rezolvati ecuatia de gradul 1 cu o necunoscuta:
             * ax+b = 0, unde a si b sunt date de intrare.*/
            Console.WriteLine("Problema numarul 1");

            float a, b, x;
            Console.WriteLine("Introduceti numarul a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul b:");
            b = float.Parse(Console.ReadLine());

            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine(x);
            }
            else
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatie nedeterminata");
                }
                else
                    Console.WriteLine("Ecuatie imposibila");
            }
        }

        private static void P2()
        {
            /*Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, 
             * unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.*/
            Console.WriteLine("Problema numarul 2");

            float a, b, c, x1, x2, delta;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Se calculeaza conform ecuatiei de grad I");
                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine(x1);
                }
                else //  b = 0
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Ecuatie nedeterminata");
                    }
                    else
                    {
                        Console.WriteLine("Ecuatie imposibila");
                    }
                }
            }
            else //  a !=0
            {
                Console.WriteLine("Calculati delta si comparati delta cu 0:");
                delta = b * b - 4 * a * c;
                Console.WriteLine($"Delta = {delta}");
                if (delta < 0)
                {
                    Console.WriteLine("Solutiile sunt radacini complexe deoarece delta < 0");
                }
                else // delta >0
                {
                    Console.WriteLine("Calculati prima si a doua solutie pentru delta > 0:");
                    x1 = (float)(-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"Prima solutie este: x1 = {x1}");
                    Console.WriteLine($"A doua solutie este: x2 = {x2}");
                }
            }
        }

        private static void P3()
        {
            /*Determinati daca n se divide cu k, unde n si k sunt date de intrare. */
            Console.WriteLine("Problema numarul 3");

            int n, k;
            Console.WriteLine("Introduceti valoarea lui n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui k:");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("n il divide pe k");
            else
                Console.WriteLine("n nu il divide pe k");
        }

        private static void P4()
        {
            /*Detreminati daca un an y este an bisect. */
            Console.WriteLine("Problema numarul 4");

            int n;
            Console.WriteLine("Introduceti anul:");
            n = int.Parse(Console.ReadLine());

            if (((n % 4 == 0) && (n % 100 != 0)) || (n % 400 == 0))
                Console.WriteLine("Anul este bisect");
            else
                Console.WriteLine("Anul nu este bisect");
        }

        private static void P5()
        {
            /*Extrageti si afisati a k-a cifra de la sfarsitul unui numar. 
            Cifrele se numara de la dreapta la stanga.*/
            Console.WriteLine("Problema numarul 5");

            int n, k, c, i;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti-l pe k:");
            k = int.Parse(Console.ReadLine());
            i = 0;
            c = 0;

            do
            {
                i++;

                if (i == k)
                {
                    c = n % 10;
                }
                n = n / 10;
            }
            while (n != 0);
            Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului este {c}");
        }

        private static void P6()
        {
            /*Detreminati daca trei numere pozitive a, b si c 
             * pot fi lungimile laturilor unui triunghi. */
            Console.WriteLine("Problema numarul 6");

            float a, b, c;
            Console.WriteLine("Introduceti lungimile laturilor triunghiului:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("Pot forma un triunghi.");
            else
                Console.WriteLine("Nu pot forma un triunghi.");
        }

        private static void P7()
        {
            /*(Swap) Se dau doua variabile numerice a si b ale carori valori
             * sunt date de intrare. Se cere sa se inverseze valorile lor. */
            Console.WriteLine("Problema numarul 7");

            int a, b, aux;
            Console.WriteLine("Valoarea lui a este:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valoarea lui b este:");
            b = int.Parse(Console.ReadLine());
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Dupa inversare, noua valoare a lui a este {a}");
            Console.WriteLine($"Dupa inversare, noua valoare a lui b este {b}");
        }

        private static void P8()
        {
            /*(Swap restrictionat) Se dau doua variabile numerice a si b ale carori
             * valori sunt date de intrare.Se cere sa se inverseze valorile lor fara 
             * a folosi alte variabile suplimentare.*/
            Console.WriteLine("Problema numarul 8");

            int a, b;
            Console.WriteLine("Introduceti variabila a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti variabila b:");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Noua valoare a lui a dupa inversare este {a}");
            Console.WriteLine($"Noua valoare b lui a dupa inversare este {b}");
        }

        private static void P9()
        {
            /* Afisati toti divizorii numarului n.*/
            Console.WriteLine("Problema numarul 9");

            int n;
            int i;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());

            for (i = 1; i < n; i++)
            {
                if (n % i == 0)
                    Console.WriteLine(i);
            }
        }

        private static void P10()
        {
            /* 10.Test de primalitate. Determinati daca un numar n este prim.*/
            Console.WriteLine("Problema numarul 10");

            int n;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Numarul nu e prim");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("Numarul e prim");
                return;
            }

            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine("Numarul nu e prim deoarece i-am gasit cel putin un divizor");
                    return;
                }
            }
            Console.WriteLine("Numarul e prim");
        }

        private static void P11()
        {
            /* Afisati in ordine inversa cifrele unui numar n*/
            Console.WriteLine("Problema numarul 11");

            int n, n1, inv;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            n1 = n;
            inv = 0;
            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine($"Inversul numarului {n1} este {inv}");
        }

        private static void P12()
        {
            /* Determinati cate numere integi divizibile 
             * cu n se afla in intervalul [a, b].*/
            Console.WriteLine("Problema numarul 12");

            int n, c, i, a, b;
            Console.WriteLine("Introduceti capetele intervalului:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            c = 0;

            for (i = a; i <= b; i++)
            {
                if (i % n == 0)
                    c++;
            }
            Console.WriteLine($"In intervalul [{a},{b}] se gasesc {c} numere intregi divizibile cu {n}");
        }

        private static void P13()
        {
            /* Determianti cati ani bisecti sunt intre anii y1 si y2.*/
            Console.WriteLine("Problema numarul 13");

            int c, y1, y2, i;
            Console.WriteLine("Introduceti anii y1 si y2:");
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            c = 0;
            for (i = y1; i <= y2; i++)
            {
                if (((i % 4 == 0) && (i % 100 != 0)) || (i % 400 == 0))
                {
                    Console.WriteLine($"{i} este an bisect");
                    c++;
                }
            }
            Console.WriteLine($"Numarul de ani bisecti cuprinsi intre anii {y1} si {y2} este {c}");
        }

        private static void P14()
        {
            /* Determianti daca un numar n este palindrom.
             * (un numar este palindrom daca citit invers
             * obtinem un numar egal cu el, de ex. 121 sau 12321.*/
            Console.WriteLine("Problema numarul 14");

            int n, n1, inv;
            bool IsPalindrom = false;
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            n1 = n;
            inv = 0;

            while (n != 0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            if (n1 == inv)
            {
                IsPalindrom = true;
                Console.WriteLine("Numarul este palindrom");
            }
            if (IsPalindrom == false)
                Console.WriteLine("Numarul nu este palindrom");
        }

        static void P15()
        {
            /* Se dau 3 numere.Sa se afiseze in ordine crescatoare.*/
            Console.WriteLine("Problema numarul 15");

            int a, b, c, aux;
            Console.WriteLine("Introduceti cele 3 numere:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > c) { aux = b; b = c; c = aux; }

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}");
        }

        private static void P16()
        {
            /*Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)*/
            Console.WriteLine("Problema numarul 16");

            int a, b, c, d, e, aux;
            Console.WriteLine("Introduceti cele 5 numere:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (a > d) { aux = a; a = d; d = aux; }
            if (a > e) { aux = a; a = e; e = aux; }

            if (b > c) { aux = b; b = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > e) { aux = b; b = e; e = aux; }

            if (c > d) { aux = c; c = d; d = aux; }
            if (c > e) { aux = c; c = e; e = aux; }

            if (d > e) { aux = d; d = e; e = aux; }

            Console.WriteLine($"Numerele in ordine crescatoare sunt: {a}, {b}, {c}, {d}, {e}");
        }


        private static void P17()
        {
            /*Determianti cel mai mare divizor comun si cel mai mic multiplu 
             * comun a doua numere. Folositi algoritmul lui Euclid. */
            Console.WriteLine("Problema numarul 17");

            int a, b, p, Cmmdc, Cmmmc;
            Console.WriteLine("Introduceti cele doua numere:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Cmmdc = a;
            Cmmmc = (a * b) / Cmmdc;
            Console.WriteLine($"Cmmdc a celor doua numere este {Cmmdc}");
            Console.WriteLine($"Cmmmc a celor doua numere este {Cmmmc}");
        }

        private static void P18()
        {
            /* Afisati descompunerea in factori primi ai unui numar n. 
             * De ex. pentru n = 1176 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.*/
            Console.WriteLine("Problema numarul 18");

            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p = 0;
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n /d;
                }
                if (p != 0)
                    Console.Write($" {d} ^ {p} x ");
                d++;

                if (n > 1 && d * d > n)
                    d = n;
            }
            Console.Write('1');
            Console.WriteLine();
            Console.ReadKey();
        }
        

        private static void P19()
        {
            /* Determinati daca un numar e format doar cu 2 cifre care
               se pot repeta.De ex. 23222 sau 9009000 sunt astfel de
               numere, pe cand 593 si 4022 nu sunt. */
            Console.WriteLine("Problema numarul 19");

            int n, u, c;
            int[] v = new int[10];
            Console.WriteLine("Introduceti numarul n:");
            n = int.Parse(Console.ReadLine());
            c = 0;
            if (n <= 1000)
                Console.WriteLine("Numarul nu este format doar cu doua cifre care se repeta deoarece nu are numarul suficient de cifre");
            while (n != 0)
            {
                u = n % 10;
                v[u]++;
                n = n / 10;
            }
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > 0)
                    c++;
            }
            if (c == 2)
                Console.WriteLine("Numarul e bun, are doar doua cifre egale.");
            else
                Console.WriteLine("Numarul nu e bun pt ca nu are doar doua cifre egale.");
        }


        private static void P20()
        {
            /* Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).
             * Exemplu: 13 / 30 = 0.4(3). (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
            O fractie este neperiodica daca numitorul este de forma 2 ^ m * 5 ^ n unde m si n 
            sunt mai mari sau egale decat 0. O fractie este periodica simpla daca numitorul nu
            se divide cu 2 si nici cu 5. O fractie este periodica mixta daca se divide cu 2 si / sau 5
            SI se mai divide si cu alte numere prime diferite de 2 si 5.*/
            Console.WriteLine("Problema numarul 20");

            int m, n, m1, n1, a, b, cmmdc;
            Console.WriteLine("Introduceti numarul m intreg:");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul n diferit de zero:");
            n = int.Parse(Console.ReadLine());
            m1 = m;
            n1 = n;

           //  aducem fractia la forma ireductibila prin scaderi repetate cu algoritmul
           //  lui Euclid si impartim numerele m si n cu cmmdc gasit//
            while (m1 != n1)
            {
              if (m1 > n1)
              m1 = m1 - n1;
              else
              n1 = n1 - m1;
            }
            cmmdc = m1;
            Console.WriteLine($"Cmmdc a celor doua numere este {cmmdc}");
            a = m / cmmdc;
            b = n / cmmdc;
            Console.WriteLine($"Fractia este adusa la forma ireductibila: {a} / {b}");

            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n; //rest
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;

            do
            {
             cifra = parteFract * 10 / n;
             cifre.Add(cifra);
             //Console.Write($"{cifra}");
             rest = parteFract * 10 % n;
               if (!resturi.Contains(rest))
               {
                 resturi.Add(rest);
               }
               else
               {
                 periodic = true;
                 break;
               }
               parteFract = rest;
            }
            while (rest != 0);

              if (!periodic)
              {
                 foreach (var item in cifre)
                 {
                    Console.Write(item);
                 }
              }
              else
              {
                 for (int i = 0; i < resturi.Count; i++)
                 { 
                    if(resturi[i] == rest)
                    {
                      Console.Write("(");
                    }
                   Console.Write(cifre[i]);
                 }
                 Console.WriteLine(")");
              }
        }

        private static void P21()
        {
            /*Ghiciti un numar intre 1 si 1024  prin intrebari de forma
             * "numarul este mai mare sau egal decat x?"*/
            Console.WriteLine("Problema numarul 21");

            int nr, x;
            Random rnd = new Random();
            x = rnd.Next(1024);
            do
            {
                Console.WriteLine("Dati un numar cuprins intre 1 si 1024");
                nr = int.Parse(Console.ReadLine());
                Console.WriteLine("Numarul introdus este mai mic sau mai mare decat numarul cautat?");
                if (nr < x)
                    Console.WriteLine("Numarul introdus este prea mic");
                if (nr > x)
                    Console.WriteLine("Numarul introdus este prea mare");
            }
            while (nr != x);
            Console.WriteLine("Felicitari! Ai ghicit numarul, acesta este {0}", x);
        }
    }
}
       
    













    















