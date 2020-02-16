using System;
using System.Linq;

namespace MediaNumeri
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Di quanti numeri vuoi fare la media? ");
            int n = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            double a;
            double[] somma = new double[n];
            for (int i = 0; i < n; i++) {
                Console.Write("Inserisci un numero: ");
                a = Convert.ToDouble(Console.ReadLine());
                somma[i] = a;
                s = s + a;
            }
            Console.WriteLine("----------");
            Console.Write("I numeri digitati sono: \t\t");
            Console.Write(string.Join(", ", somma));
            Console.WriteLine("");
            Console.WriteLine("-");
            Console.WriteLine("La media è di: \t\t\t\t" + s/n);
            Console.WriteLine("-");
            Console.WriteLine("Il numero maggiore è: \t\t\t" + somma.Max());
            Console.WriteLine("-");
            Console.WriteLine("Il numero minore è: \t\t\t" + somma.Min());
            Console.WriteLine("-");
            Console.WriteLine("La somma dei numeri è: \t\t\t" + somma.Sum());
            Console.WriteLine("----------");
        }
    }
}
