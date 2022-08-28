using System;
using System.Linq;

  class Program
    {
        public static void Main(string[] args)
        {
            string frase;
            char a;
            int cont;
          
            Console.Write("Informe uma frase: ");
            frase = Console.ReadLine();
          
            Console.Write("Informe a letra: ");
            a = Console.ReadLine().ToCharArray()[0];
          
            cont = CountLetter(frase.ToCharArray(), a);
          
            Console.WriteLine(string.Format("A letra {0} aparece {1} vezes", a, cont));
        }

        static int CountLetter(char[] frase, char a)
        {
            if (frase.Length == 1)
            {
                return 0;
            }
            frase = frase.Skip(1).Take(frase.Length-1).ToArray();
            return CountLetter(frase, a) + (frase[0] == a ? 1 : 0);
        }
    }
