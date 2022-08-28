using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        public static void Main(string[] args)
        {
            string frase;
              
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.Write("Frase sem vogal: ");
            Console.Write(tiravol(frase.ToCharArray()));
        }

        static char[] vol = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 'á', 'é', 'í', 'ó', 'ú', 'ã', 'õ', 'Ã', 'Õ', 'â', 'ê', 'î', 'ô', 'û', 'Â', 'Ê', 'Î', 'Ô', 'Û'};

        static string tiravol(char[] txt, int aux = -1, string output = "")
        {
            aux++;
            if (aux == txt.Length)
            {
                return output;
            }
            if (!vol.ToList().Contains(txt[aux]))
            {
                output += txt[aux];
            }
            return tiravol(txt, aux, output);
        }
    }
