using System;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        double altura, peso;

        Console.WriteLine("Digite sua altura em centimetro: ");
        altura = Convert.ToDouble (Console.ReadLine());

        Console.WriteLine("Digite seu peso: ");
        peso = Convert.ToDouble (Console.ReadLine());

        double result = p.calc(altura, peso);
        p.mensagem(result);
        




    }
}