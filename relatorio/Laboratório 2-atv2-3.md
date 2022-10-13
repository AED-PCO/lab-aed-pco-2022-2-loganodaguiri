using System;

class Program {
  public static void Main (string[] args) {
    int[] vet = tamanhovetor();
            int[] sortedArr = ordenacaobinaria(vet);
            Console.WriteLine("O vetor ordenado é: " + string.Join(",", sortedArr));//mostra reusltado 
            Console.ReadKey();
  }
  
      private static int[] ordenacaobinaria(int[] vet)
        {
            for(int i = 1; i < vet.Length; i++) 
            {
                int pos = busca(vet, vet[i], 0, i);
                vet = ShiftArray(vet, i, pos);
            }
            return vet;
        }

        private static int[] tamanhovetor()
        {
            Console.WriteLine("O tamnho do vetor é:"); //definir o tamanho do vetor
            int tam = int.Parse(Console.ReadLine());
            int[] vet = new int[tam];
            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Informe o valor da possição "+ (i + 1)); //informar os valores de cada posição do vetor
                vet[i] = int.Parse(Console.ReadLine());
            }

            return vet;
        }

        private static int busca(int[] vet, int n, int startPos, int endPos) //busca is valores do vetor
        {
            int midPos = (startPos + endPos) / 2;
            if (startPos > endPos)
            {
                return vet[midPos] > n ? midPos : midPos+1;
            }
            if (vet[midPos] == n)
            {
                return midPos;
            }
            if (vet[midPos] > n)
            {
                return busca(vet, n, startPos, midPos - 1);
            }
            return busca(vet, n, midPos + 1, endPos);
        }

        static int[] ShiftArray(int[] vet, int oldPos, int newPos) //ordenar os valores do vetor
        {
            int val = vet[oldPos];
            if (vet.Length > 1)
            {
              for(int i = oldPos; i >= newPos; i--)
                {
                    if (i != newPos)
                    {
                        vet[i] = vet[i - 1];
                    }
                }
            }
            vet[newPos] = val;
            return vet;
        }
}
