using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
    class Avion : Vehiculo,IComporta
    {
        public void Despegar()
        {
            Arrancar();
            Console.WriteLine("despegando");
        }
        public void Aterrizar()
        {
            PararMotor();
            Console.WriteLine("aterrizando abrir pista");
        }
        public override void Conducir()
        {
            Console.WriteLine("Piloto Aviador");
        }
        // si no la ocupo no debo de implementar la interface
        public int NumeroLlantas()
        {
            return 2;
        }
    }
}
