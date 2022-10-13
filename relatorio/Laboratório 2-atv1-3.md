using System;

class Program
{
    public static void Main(string[] args)
    {
        int[] vet = new int[5] { 10, 16, 26, 28, 80 };  //define os elementos do vetor
        int tam = 5; //Guarda o tamanho do vetor
        int valor = 50; //valor a ser pesquisado
        int pesq = PesquisaBinaria(vet, valor, tam); //pasgem de valor por parametro

        if (pesq == -1)
        {
            Console.WriteLine("Valor não encontrado"); //mostra resultado
        }
        else
        {
            Console.WriteLine("Valor encontrado na posição " + (pesq + 1) + " do vetor"); //mostra resultado
        }
    }

    public static int PesquisaBinaria(int[] vet, int chave, int Tam) //pesquisa binaria
    {
        int min = 0; 
        int max = Tam - 1;
        int meio;

        while (min <= max) //Enquanto o valor minomo for menor ou igual ao valor maximo ele vai fazer a comparação de ir partindo o vetor no meio para achar o valor procurado
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
