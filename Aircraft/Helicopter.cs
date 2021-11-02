using System;

namespace AppAbstractFactory.Aircraft
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros ok, ligando as helices.");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem!!!");
        }
    }
}
