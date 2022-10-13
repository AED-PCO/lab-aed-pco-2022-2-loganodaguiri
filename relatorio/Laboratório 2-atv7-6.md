using System;

class Program {
  public static void Main (string[] args) {
            int[] numeros = new int[6]{100,21,60,23,7,9}; //define tamho do vetor
    
            Console.Write("\nVetor Inicial: "); //mostra resultado
    
            for (int k = 0; k < 6; k++)
            {
                Console.Write(numeros[k] + " ");
            }
            Console.Write("\nVetor Ordenado: "); //mostra resultado
    
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

            while ((esquerda <= eol) && (meio <= direita)) //compara os valores do vetor
            {
                if (numeros[esquerda] <= numeros[meio]) //troca de posição
                    temp[pos++] = numeros[esquerda++];
                else
                    temp[pos++] = numeros[meio++];
            }
            while (esquerda <= eol) //compara os valores do vetor
                temp[pos++] = numeros[esquerda++]; //troca de posição
            while (meio <= direita)//compara os valores do vetor
                temp[pos++] = numeros[meio++];//troca de posição
            for (i = 0; i < num; i++)
            {
                numeros[direita] = temp[direita];
                direita--;
            }
        }

        static public void MergeSort(int[] numeros, int esquerda, int direita)
        {
            int meio;
            if (direita > esquerda)//compara os valores do vetor
            {
                meio = (direita + esquerda) / 2; //troca de posição
                MergeSort(numeros, esquerda, meio);
                MergeSort(numeros, (meio + 1), direita);
                PrincipalOrdenação(numeros, esquerda, (meio + 1), direita);
            }
        }
}
