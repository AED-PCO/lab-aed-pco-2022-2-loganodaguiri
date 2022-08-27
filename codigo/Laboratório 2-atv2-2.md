using System;

class Program {
  public static void Main (string[] args) {
    
    int x;
    
    Console.WriteLine ("Escreva a posição do numero que você quer saber da sequencia de fibonacci: ");
        x = int.Parse(Console.ReadLine());

    int fibo = fib(x);

    Console.WriteLine ("O numero corespondente a posição "+x+" da sequencia de fibonacci é: "+fibo);
  }

    static int fib(int x){
      int resu;
      
      if(x==1){
        return 1;
      }
      if(x==2){
        return 1;
      }
      
      resu = fib(x-1)+fib(x-2);

      return resu;
      
    }

  
}
