using System;

namespace AppAbstractFactory.Aircraft
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Sem vemtos, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Carga aclopada.");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando decolagem e trajeto...");
        }
    }
}
