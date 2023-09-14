using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi broj n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n+1];
            niz[0] = 1;
            niz[1] = 2;
            for(int i = 2; i < (n-1); i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];
                //Console.WriteLine(niz[i]);
            }
            Console.WriteLine(n+" član Fibonaccievog niza je: " + niz[n-2]);
            Console.ReadKey();
        }
    }
}
