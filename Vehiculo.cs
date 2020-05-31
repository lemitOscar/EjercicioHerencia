using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    class Vehiculo
    {

        public void Arrancar()
        {
            Console.WriteLine("esta encendido");
        }
        public void PararMotor()
        {
            Console.WriteLine("Apagando....");
        }
        public virtual void Conducir()
        {
            Console.WriteLine("quien conduce?");
        }
    }
}
