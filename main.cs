using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite um número:");
   int n=  int.Parse(Console.ReadLine());

    int f = fatorial (n);
    Console.WriteLine("O fatorial é: " + f);
    
  }

  public static int fatorial(int numero){
    if (numero ==1)
    return 1;

    return numero * fatorial(numero-1);
  }
}