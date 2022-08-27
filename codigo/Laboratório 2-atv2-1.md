using System;

class Program {
  public static void Main (string[] args) {
    int n,cont=0; 
    
    Console.WriteLine ("Digite um numero: ");
    n = int.Parse(Console.ReadLine());

    for(int i=1;i<=n;i++){

      if(n%i == 0){
        cont++;
      }
      
    }

    if(cont==2){
      Console.WriteLine ("O numero: "+n+" é primo");
    }
      else{
        Console.WriteLine ("O numero: "+n+" não é primo");
      }

    int num,u,soma1=0;

    for(num=1;num<=1000;num++){
      
      for(u=1;u<num;u++){
      
        if(num%u == 0){
          soma1 = soma1 + u;
        }
      }
      if(num==soma1){
        Console.WriteLine ("O numero: "+num+" é perfeito");
        }

        soma1=0;
    }
  }
}
