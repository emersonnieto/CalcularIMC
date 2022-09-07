using System;

class Pessoa
{
    public double calc(double altura, double peso)
    {
        return peso / ((altura/100) * (altura/100));
    }

    public void mensagem(double imc)
    {
        
        if (imc < 18.5)
        {
            Console.WriteLine("imc = " +imc+ " voce esta abaixo do peso");

        }else if (imc >= 18.5 & imc < 25 )
        {
            Console.WriteLine("imc = " +imc+ "seu peso esta normal");

        }else if (imc >= 25 & imc < 30)
        {
            Console.WriteLine("imc = " +imc+ "acima do peso");

        }else if (imc >=30 & imc < 35)
        {
            Console.WriteLine("imc = " +imc+ "obesidade 1");
        }

        else if (imc >= 35 & imc < 40)
        {
            Console.WriteLine("imc = " +imc+ "obesidade 2");
        }else{
            Console.WriteLine("imc = " +imc+ " obesidade 3");
        }
    }
}