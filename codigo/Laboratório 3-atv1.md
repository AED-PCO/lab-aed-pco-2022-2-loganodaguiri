using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] vet = new int[5] { 10, 16, 26, 28, 80 };
        int tam = 5;
        int valor = 50;
        int pesq = PesquisaBinaria(vet, valor, tam);

        if (pesq == -1)
        {
            Console.WriteLine("Valor não encontrado");
        }
        else
        {
            Console.WriteLine("Valor encontrado na posição " + (pesq + 1) + " do vetor");
        }
    }

    public static int PesquisaBinaria(int[] vet, int chave, int Tam)
    {
        int min = 0;
        int max = Tam - 1;
        int meio;

        while (min <= max)
        {
            meio = (min + max) / 2;
            if (chave == vet[meio])
                return meio;
            if (chave < vet[meio])
                min = meio - 1;
            else
                min = meio + 1;
        }
        return -1;
    }

}
