using System;

namespace prodotto_ricorsione
{
    class Program
    {
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
                    Console.WriteLine("inserire il numero");
                    int n3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("inserire l'elevamento");
                    int n4 = Convert.ToInt32(Console.ReadLine());

                    int pot = potenza(n3, n4);
                    Console.WriteLine(pot);
            }
        }
    }
}
