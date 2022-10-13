using System;

class Program {
  public static void Main (string[] args) {
            int[] X = { 5, 8, 12, 9, 7, 3, 4, 15, 21, 13};
           
            int i, j, Aux;         // Variáveis Auxiliares

            Mostra(X);

            Console.WriteLine("\n");

            // Algoritmo padrão do método

            for (i = 1; i <= 10; i++)           // Desde a segunda até a última posição do vetor...
            {
                for (j = 0; j < 9; j++)         // Desde a primeira até a penúltima posição do vetor...
                {
                    Console.Write("O valor {0,2} é maior que o valor {1,2}? ", X[j], X[j + 1]);

                    Console.ReadKey(true);

                    if (X[j] > X[j + 1])        // Compara. Se o elemento atual é maior que o elemento da frente dele no vetor,
                    {
                        Console.Write("  => Trocar!\n");

                        Aux = X[j];             // Troca ele de lugar com o da frente...
                        X[j] = X[j + 1];
                        X[j + 1] = Aux;

                        Console.WriteLine();
                        
                        Mostra(X);

                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.Write("  => Não Trocar!\n");
                    }
                }
            }

            // Mostrando o Vetor Ordenado
            Console.Write("\nVetor Ordenado (BUBBLE SORT): ");

            Mostra(X);

            Console.ReadKey();
        }

  static void Mostra(int[] X)
        {
            foreach (int x in X)
            {
                Console.Write("{0,6}", x);
            }

            Console.ReadKey();
        }
    }
