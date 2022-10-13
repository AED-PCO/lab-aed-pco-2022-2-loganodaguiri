using System;

class Program {
  public static void Main (string[] args) {
          int[] X = { 3, 8, 15, 6, 9, 2, 1, 12, 5, 7 };
            int i;             // Variáveis Auxiliares

            //Console.WriteLine("Ordenação em Memória Primária - QUICK SORT");
            //Console.WriteLine("==========================================\n");

            //for (i = 0; i < 10; i++)    // Entrada dos Elementos do Vetor
            //{
            //    Console.Write("Digite o Elemento {0,2} do Vetor: ", i + 1);
            //    X[i] = int.Parse(Console.ReadLine());
            //}

            Console.Clear();

            Mostra(X);

            Quick(X, 0, 9);

            // Mostrando o Vetor Ordenado
            Console.Clear();
            
            Console.Write("\nVetor Ordenado (QUICK SORT): ");
            foreach(int x in X)
                Console.Write("{0,6}", x);

            Console.ReadKey();
  }
  static void Quick(int[] X, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = Partição(X, p, r);
                Quick(X, p, q);
                Quick(X, q + 1, r);
            }
        }

        static int Partição(int[] X, int p, int r)
        {
            int Pivô;
            int i, j;

            Pivô = X[(p + r) / 2];

            Console.WriteLine("Pivô = {0}\n", Pivô);

            i = p - 1;
            j = r + 1;

            while (i < j)
            {
                do                  // Avançar ponteiro da esquerda enquando o valor for menor que o pivô
                {
                    i++;
                    Console.WriteLine("Esq = {0,2}    => Posição {1}", X[i],i);
                } while (X[i] < Pivô);

                do                  // Retroceder ponteiro da direita enquando o valor for maior que o pivô
                {
                    j--;
                    Console.WriteLine("Dir = {0,2}    => Posição {1}", X[j],j);
                } while (X[j] > Pivô);

                

                if (i < j)                  // Se o ponteiro da esquerda for menor que o da direita
                {
                    Troca(X, i, j);         // Troca os valores apontados pela esquerda e pela direita
                }

                Mostra(X);
            }

            Console.Clear();
            
            Console.WriteLine("Vetor Ordenado:");

            Mostra(X);

            return j;                       // Retorna ponteiro da direita
        }

        static void Mostra(int[] V)
        {
            Console.WriteLine("\n");
            
            foreach (int x in V)
                Console.Write("{0,6}", x);

            Console.WriteLine("\n");

            Console.ReadKey();
        }

        static void Troca(int[] X, int i, int j)
        {
            int Aux;

            Aux = X[i];
            X[i] = X[j];
            X[j] = Aux;
        }
}
