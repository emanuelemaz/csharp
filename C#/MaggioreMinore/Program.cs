using System;

namespace Program {
class Program {
    static void Main(string[] args) {
        //Primo programma, ovviamente voglare.
        Console.WriteLine("Inserisci il primo numero: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il secondo numero: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        if (n1 > n2) {
            Console.WriteLine("Il primo numero è maggiore del secondo.");
        }
        else {
            Console.WriteLine("Il secondo numero è maggiore del primo.");
        }


        }
    }
}
