using System;

class Program {
  public static void Main (string[] args) {
    
    int[] a  = new int[5];
    int[] b  = new int[5];
    int[] c = new int[5];
    int[] d = new int[5];
    
    for(int i=0; i<5; i++){
      
      Console.WriteLine ("Digite o "+(i+1)+"° elemento do vetor A: ");
      a[i] = Convert.ToInt32(Console.ReadLine());
      }

      //ver se o vetror tem indice igual
      for(int i=0; i<5; i++){
        
        for(int j=i+1; j<5; j++){
          
          while(a[i]==a[j]){
            Console.WriteLine ("O elento "+a[j]+" é repetido favo informar outro valor: ");
            a[j] = Convert.ToInt32(Console.ReadLine());  
          }  
        }
        
      }

    for(int i=0; i<5; i++){
      
      Console.WriteLine ("Digite o "+(i+1)+"° elemento do vetor B: ");
      b[i] = Convert.ToInt32(Console.ReadLine());
      }

      //ver se o vetror tem indice igual
      for(int i=0; i<5; i++){
        
        for(int j=i+1; j<5; j++){
          
          while(b[i]==b[j]){
            Console.WriteLine ("O elento "+b[j]+" é repetido favo informar outro valor: ");
            b[j] = Convert.ToInt32(Console.ReadLine());  
          }  
        } 
      }

    bool flag;
    for(int i=0; i<5; i++){
      
      flag= false;
      for(int j=0; j<5; j++){

        if(a[i]==b[j]){
          flag= true;
          c[i]=a[i];
          break;
        }
      }

      if(flag==true){
        Console.WriteLine ("O elemento repetido no vetor a e b é: "+c[i]);
      }  
    }

    for(int i=0; i<5; i++){
      
      flag= false;
      for(int j=i+1; j<5; j++){

        if(a[i]!=b[j]){
          flag= true;
          d[i]=a[i];
          break;
        }
      }

      if(flag==true){
        Console.WriteLine ("Os elemento de a que não existem em b são: "+d[i]);
      }  
    }
    
    }
  }
