using System;

class Program {
  public static void Main (string[] args){

    int x;
  
    Console.WriteLine ("Digite um numero: ");
    x = int.Parse(Console.ReadLine());

    int fato = fat(x);

        Console.WriteLine ("O fatorial de "+x+" é igual a: "+fato);


  }

  static int fat(int x){

    int aux;
    
    if(x==0){
      return 1;
    }
    
    else{
      aux=x*fat(x-1);
      return aux;
    }
  }  
}
