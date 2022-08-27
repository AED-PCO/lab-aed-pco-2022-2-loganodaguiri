using System;

class Program {
  public static void Main (string[] args) {

    int x,y;
    
    Console.WriteLine ("Digite um numero x: ");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite um numero y: ");
    y = int.Parse(Console.ReadLine());

    int pot = potencia(x,y);

    Console.WriteLine ("O valor de "+x+" elevado a "+y+" é: "+pot);

    
  }

  static int potencia(int x, int y){

    int pot = 1;
    for(int i=0; i<y; i++){
      pot=pot*x;
    }

    return pot;
  }
}
