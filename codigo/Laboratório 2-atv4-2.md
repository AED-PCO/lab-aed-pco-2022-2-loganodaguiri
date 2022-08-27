using System;

class Program {
  public static void Main (string[] args) {
  int a,b;
    
	Console.WriteLine ("Escreva um numero: ");
  a = int.Parse(Console.ReadLine());
    
  Console.WriteLine ("Escreva mais um numero: ");
  b = int.Parse(Console.ReadLine());

  int pote = pot(a,b);
    
	Console.WriteLine("O resultado da potencia é: "+pote);

   
  }

 static int pot(int a, int b){
    if(b==0){
      return 1;
    }
   else{
     return a*pot(a,(b-1));
   }  
  }
  
}
