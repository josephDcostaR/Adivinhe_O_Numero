using System;

class Program {
  public static void Main (string[] args) {
    Random ale = new Random();
    int numero = ale.Next(1,101);

   

    while (true)
    {

    Console.WriteLine("Em intervalo de numeros de 1 a 100, qual seu palpite? ");
    int palpite = Convert.ToInt32(Console.ReadLine());
      
      if(palpite < numero)
      {
        Console.WriteLine("Que pena seu palpite é menor que o numero");
      }

      else if (palpite > numero)
      {
         Console.WriteLine("Que pena seu palpite é maior que o numero");
      }

      else if (palpite == numero)
       {
         Console.WriteLine("Parabens voce acertou");
           break;
       }

    
    }
    
  }
}