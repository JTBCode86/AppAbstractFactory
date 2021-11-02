using AppAbstractFactory.Aircraft;
using AppAbstractFactory.LandVehicles;

namespace AppAbstractFactory.Factories
{
    class NineNineTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportVehicle()
        {
            return new MotorCycle();
        }
    }
}
