using System;

class Program {
  public static void Main (string[] args) {
    int[] vetor = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6};

            Console.WriteLine("\nVetor Inicial:");
            foreach (int aa in vetor)
                Console.Write(aa + " ");

            int[] CoutingSort = new int[vetor.Length];

            int ValorMin = vetor[0];
            int ValorMax = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < ValorMin) ValorMin = vetor[i];
                else if (vetor[i] > ValorMax) ValorMax = vetor[i];
            }

            int[] cont = new int[ValorMax - ValorMin + 1];

            for (int i = 0; i < vetor.Length; i++)
            {
                cont[vetor[i] - ValorMin]++;
            }

            cont[0]--;
            for (int i = 1; i < cont.Length; i++)
            {
                cont[i] = cont[i] + cont[i - 1];
            }

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                CoutingSort[cont[vetor[i] - ValorMin]--] = vetor[i];
            }

            Console.WriteLine("\nVetor Ordenado:");
            foreach (int aa in CoutingSort)
                Console.Write(aa + " ");
        }
    }
