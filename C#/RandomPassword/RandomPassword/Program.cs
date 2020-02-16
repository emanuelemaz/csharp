using System;
using System.Collections.Generic;

namespace RandomPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            //Charset   es. charset[x]
            List<char> charset = new List<char> () {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            //Numero caratteri
            Console.WriteLine("Di quanti caratteri vuoi la password?");
            int i = Convert.ToInt32(Console.ReadLine());
            //Generazione seme random
            Random semeRandom = new Random();
            //Generazione lista passsword   es. randomPassword[x]   randomPassword.Add()
            List<char> randomPassword = new List<char> ();
            //loop per aggiungere alla password
            for (int j = 0; j <= i; j++) {
                int k = semeRandom.Next(0,62);
                randomPassword.Add(charset[k]);
            }

            string randomPasswordString = string.Join("", randomPassword.ToArray());
            Console.WriteLine(randomPasswordString);
        }
    }
}
