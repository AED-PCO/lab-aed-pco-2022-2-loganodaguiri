//FILA
using System;

class Program
{
    public static void Main(string[] args)
    {

        int[] v = new int[5];
        int pos = 0;
        int i = 0;
        int resp;

      for(int j=0; j<5; j++){
         Console.Write("Digite o elemento ["+ (j+1) +"] do vetor: ");
           v[j] = int.Parse(Console.ReadLine());
      }
      
        Console.WriteLine("Deseja remover um elemento?");
        Console.WriteLine("Caso sim digite 1 / caso não digite 2");
        resp = int.Parse(Console.ReadLine());

      while(resp!=2){
        for (i = pos; i < 5 - 1; i++)
        {
            v[i] = v[i + 1];
        }

        for (i = 0; i < 5; i++)
        {
            Console.Write(v[i]);
        } 
        Console.Write("\n");
        Console.WriteLine("Deseja remover outro elemento?");
        Console.WriteLine("Caso sim digite 1 / caso não digite 2");
        resp = int.Parse(Console.ReadLine());
      }
        Console.WriteLine("Obrigado por usar o programa");
    }
}
//lista
using System;

class Program
{
    public static void Main(string[] args)
    {

        int[] v = new int[5];
        int pos;
        int i = 0;
        int resp;

      for(int j=0; j<5; j++){
         Console.Write("Digite o elemento ["+ (j+1) +"] do vetor: ");
           v[j] = int.Parse(Console.ReadLine());
      }
      
        Console.WriteLine("Deseja remover um elemento?");
        Console.WriteLine("Caso sim digite 1 / caso não digite 2");
        resp = int.Parse(Console.ReadLine());

      while(resp!=2){
        Console.WriteLine("Qual elemento você deseja remover? ");
        pos= int.Parse(Console.ReadLine());
        bool aux = false;
        int max = 5;
        for (i = 0; i < max; i++)
        {
          if((pos-1==i) || (aux == true)&&(i < max-1)){
            aux = true;
            v[i]=v[i+1];
          }
        }
        
        for (i = 0; i < 5; i++)
        {
            Console.Write(v[i]+" ");
        } 
        Console.Write("\n");
        Console.WriteLine("Deseja remover outro elemento?");
        Console.WriteLine("Caso sim digite 1 / caso não digite 2");
        resp = int.Parse(Console.ReadLine());
      }
        Console.WriteLine("Obrigado por usar o programa");
    }
}
//pilha
using System;

class Program {
  public static void Main (string[] args) {
    int[] v = new int[5];
    int resp;
    int pos = 4;
    int i = 0;
    int aux=5;

      for(int j=0; j<5; j++){
         Console.Write("Digite o elemento ["+ (j+1) +"] do vetor: ");
           v[j] = int.Parse(Console.ReadLine());
      }

     Console.WriteLine("Deseja remover um elemento?");
     Console.WriteLine("Caso sim digite 1 / caso não digite 2");
     resp = int.Parse(Console.ReadLine());

      while(resp!=2 && pos!=0){
        for (i = pos; i < 5 ; i++)
        {
          v[i] = v[i - 1];  
        }
        aux--;
        for (i = 0; i < aux; i++)
        {
          Console.Write(v[i]+" ");
        } 
        Console.Write("\n");
        Console.WriteLine("Deseja remover outro elemento?");
        Console.WriteLine("Caso sim digite 1 / caso não digite 2");
        resp = int.Parse(Console.ReadLine());
        pos--;
      }

      if(pos==0){
        Console.WriteLine("Numero maximo de remoções posiveis atingida, obrigado por usar o programa");
      }

    else{
        Console.WriteLine("Obrigado por usar o programa");
      }
    
  }
}
