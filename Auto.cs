using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    class Auto : Vehiculo,IComporta
    {
        public void Frenar()
        {
            PararMotor();
            Console.WriteLine("el auto freno");
        }
        public void Acelerar()
        {
            Arrancar();
            Console.WriteLine("el auto Aceleara");
        }

        public override void Conducir()
        {
            Console.WriteLine("Piloto");
        }

        //aqui se creo mi interface
        public int NumeroLlantas()
        {
            return 4;
           
        }
    }
}
