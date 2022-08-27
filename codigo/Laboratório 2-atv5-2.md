using System;

class Program {
  public static void Main (string[] args) {
    int[] vet = new int[3];
    int pos=2;

    for(int i=0; i<3; i++){
      Console.WriteLine ("Digite um numero: ");
      vet[i] = int.Parse(Console.ReadLine());
    }

    int soma = som(vet,pos);
    
    Console.WriteLine ("A soma dos valores pares do vetor é: "+soma);
  }

  static int som(int []vet, int pos){
    if(pos==-1){
      return 0;
    }

    else if(vet[pos]%2==0){
      return vet[pos]+som(vet,pos-1);
    }
    else{
      return som(vet,pos-1);
    }
  }
}
