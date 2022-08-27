using System;

class Program {
  public static void Main (string[] args) {

    int[,] array = new int[5, 3];
    int [] soma = new int [5];
    int [] soma1 = new int [3];
    int cont=0,cont1=0;

    for(int i=0; i<5;i++){
      for(int j=0; j<3;j++){
        Console.WriteLine ("Digite o "+(i+1)+"° da linha "+(i+1)+" e da coluna "+(j+1));
        array[i,j] = int.Parse(Console.ReadLine());
      }
    }

    for(int i=0; i<5;i++){
      Console.Write("\n");
      for(int j=0; j<3;j++){
        Console.Write(array[i,j]+" ");
      }
    }

    Console.Write("\n ");

    Console.Write("\n");
    while(cont<5){
      for(int i=0; i<3; i++){
        soma[cont]+=array[cont,i];
      }
      cont++;
    }
    
    for(int i=0; i<5; i++){
      Console.WriteLine ("A soma da "+(i+1)+"° linha é: "+soma[i]);
    }

    Console.Write("\n ");

    while(cont1<3){
      for(int i=0; i<5; i++){
        soma1[cont1]+=array[i,cont1];
      }
      cont1++;
    }

    for(int i=0; i<3; i++){
      Console.WriteLine ("A soma da "+(i+1)+"° coluna é: "+soma1[i]);
    }
    
  }
}
