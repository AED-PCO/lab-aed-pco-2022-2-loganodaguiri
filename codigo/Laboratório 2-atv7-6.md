using System;

class Program {
  public static void Main (string[] args) {
            int[] numeros = new int[6]{100,21,60,23,7,9};
    
            Console.Write("\nVetor Inicial: ");
    
            for (int k = 0; k < 6; k++)
            {
                Console.Write(numeros[k] + " ");
            }
            Console.Write("\nVetor Ordenado: ");
    
            for (int k = 0; k < 6; k++){
            Console.Write(numeros[k]+" ");
            }

            MergeSort(numeros, 0, 6 - 1);
  }

          static public void PrincipalOrdenação(int[] numeros, int esquerda, int meio, int direita)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (meio - 1);
            pos = esquerda;
            num = (direita - esquerda + 1);

            while ((esquerda <= eol) && (meio <= direita))
            {
                if (numeros[esquerda] <= numeros[meio])
                    temp[pos++] = numeros[esquerda++];
                else
                    temp[pos++] = numeros[meio++];
            }
            while (esquerda <= eol)
                temp[pos++] = numeros[esquerda++];
            while (meio <= direita)
                temp[pos++] = numeros[meio++];
            for (i = 0; i < num; i++)
            {
                numeros[direita] = temp[direita];
                direita--;
            }
        }

        static public void MergeSort(int[] numeros, int esquerda, int direita)
        {
            int meio;
            if (direita > esquerda)
            {
                meio = (direita + esquerda) / 2;
                MergeSort(numeros, esquerda, meio);
                MergeSort(numeros, (meio + 1), direita);
                PrincipalOrdenação(numeros, esquerda, (meio + 1), direita);
            }
        }
}
