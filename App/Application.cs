using AppAbstractFactory.Factories;
using AppAbstractFactory.Aircraft;
using AppAbstractFactory.LandVehicles;

namespace AppAbstractFactory.App
{
    class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application (ITransportFactory factory) 
        {
            aircraft = factory.CreateTransportAircraft();
            vehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute() 
        {
            vehicle.StartRoute();
            aircraft.StartRoute();   
        }
    }
}
