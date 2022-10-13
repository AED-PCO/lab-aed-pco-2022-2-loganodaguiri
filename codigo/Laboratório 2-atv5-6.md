using System;

class Program {
  static void Main(string[] args)
        {
            int[] vetor = new int[] { 56, 12, 99, 32, 1, 95, 25, 5, 100, 84 };
            int n = vetor.Length;
            int i;
            Console.Write("Vetor Inicial:");
            for (i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");
            }
            ShellSort(vetor, n);
            Console.Write("\nVetor Ordenado:");
            for (i = 0; i < n; i++)
            {
                Console.Write(vetor[i] + " ");

            }
        }
  
  public static void ShellSort(int[] vetor, int n) {
   int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = vetor[i];
                    while ((j >= pos) && (vetor[j - pos] > temp))
                    {
                        vetor[j] = vetor[j - pos];
                        j = j - pos;
                    }
                    vetor[j] = temp;
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else
                    pos = 1;
            }
        }
}
