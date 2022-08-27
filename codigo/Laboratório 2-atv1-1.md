using System;

class Program {
  public static void Main (string[] args) {
    
    int resto, resulado;
    double soma,quadrado;
    int numero =  1000;

    while(numero>999 && numero<=9999){
      resulado=numero/100;
      resto=numero%100;
      soma= resulado+resto;
      
      quadrado=Math.Pow(soma,2);

      if(quadrado == numero){
        Console.WriteLine("O numero "+ numero+" se encaixa na regra.");
      }
      
      numero = numero + 1;
    }
    
  }
  
}
