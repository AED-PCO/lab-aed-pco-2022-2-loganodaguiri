using System;

class Program {
  public static void Main (string[] args) {
    int n,fatorial=1; 
    
    Console.WriteLine ("Digite um numero: ");
    n = int.Parse(Console.ReadLine());

    for(int i=1;i<=n;i++){

      fatorial = fatorial * i;   
      
    }
  
    Console.WriteLine ("O fatorial de "+n+" é igual a: "+fatorial);
    
  }
}
