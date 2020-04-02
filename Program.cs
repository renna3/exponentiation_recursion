using System;

namespace prodotto_ricorsione
{
    class Program
    {

        public static int prodotto(int p, int m)
        { 
            if (p == 1)
                return m;

            else {
                p--;
                return m + prodotto(p, m);
                
            }
        }      

        public static int potenza(int b, int e)
        {
            if (e == 1)
                return b;

            else
            {
                e--;
                return b * potenza(b, e);
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("scegliere:");
            Console.WriteLine("1) prodotto");
            Console.WriteLine("2) elevamento");
            int scelta = Convert.ToInt32(Console.ReadLine());


            switch (scelta)
            {

                case 1:

                    Console.WriteLine("inserire il numero");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserire il moltiplicatore");
                    int n2 = Convert.ToInt32(Console.ReadLine());

                    int prod = prodotto(n1, n2);
                    Console.WriteLine(prod);

                    break;

                case 2:
                    Console.WriteLine("inserire il numero");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserire l'elevamento");
                    int n4 = Convert.ToInt32(Console.ReadLine());

                    int pot = potenza(n3, n4);
                    Console.WriteLine(pot);

                    break;



            }
        }
    }
}
