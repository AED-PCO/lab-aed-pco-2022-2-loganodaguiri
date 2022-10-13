![image](https://user-images.githubusercontent.com/54037849/195617029-6cd63789-2db2-41e8-acf8-5d723762861b.png)
1- multiplicação

2- for(int i=n; i>1; i--){
res = res*i;
}

3- f(n) = n - 1 ou seja a estrutura de repetição será executada n-1 vezes

4- Não


![image](https://user-images.githubusercontent.com/54037849/195618394-8fa999d4-dbb1-4f21-97d7-8b1c014f56ed.png)

1- comparação

2- for(int i=0; i<arr.length; i++){
if(arr[i] == x) return x;
}

3- Esse codigo vai percorrer todo o vetor a procura de um elemento que seja igual a x caso não encontre ele so sai

4-Sim, Pior Caso: O(n)/ Caso Médio: o(n)/2  / Melhor Caso: O(1)

![image](https://user-images.githubusercontent.com/54037849/195620417-c83fcc80-6652-4259-8756-ebd4d627669d.png)

1- atribuição de adição e comparação.

2- if(j!=pos)
res[pos] += arr1[pos]/arr1[j]; 

3- O codigo que está como exemplo acima ira fazer o tamnaho do vetor elevado ao quadrado

4- Não

![image](https://user-images.githubusercontent.com/54037849/195622263-e097ad8a-d21d-490c-b65b-e3bccdd4e2ab.png)

1- Comparação, atribuição e atribuição de adição.

2- for(int i=0; i<dados.length; i++){
            double soma=0.0;
            for(int j=0; j<=i; j++)
                soma += dados[j];
            vet[i] = soma/(i+1);
        }

3- O codigo ira fazer n(n-i) e cada vez que isso ocorrer ele vai incrementar o i

4-Não
