using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Avion liz = new Avion();
            liz.Despegar();
            liz.Conducir();
            liz.Aterrizar();
            Console.WriteLine(liz.NumeroLlantas());


            Console.WriteLine("............");

            Console.WriteLine("Hello World! x222");
            Auto jess = new Auto();
            jess.Acelerar();
            jess.Frenar();
            jess.Conducir();
            Console.WriteLine(jess.NumeroLlantas());
            
        }
    }
}
