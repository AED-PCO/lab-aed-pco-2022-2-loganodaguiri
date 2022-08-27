using System;

class Program {
  public static void Main (string[] args) {
    int x,y;
    
    Console.WriteLine ("Escreva um numero: ");
    x = int.Parse(Console.ReadLine());
    
    Console.WriteLine ("Escreva um numero: ");
    y = int.Parse(Console.ReadLine());

    int multi = mul(x,y);

    Console.WriteLine ("O resultado é: "+multi);
    
  }

  static int mul(int x, int y){
    
    if (y == 1)
        return x;

    if (y > 0)
        return mul(x, y - 1)+x;
    
    else
        return mul(x, y + 1)+x;

  }
}
