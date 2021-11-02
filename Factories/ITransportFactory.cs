using AppAbstractFactory.Aircraft;
using AppAbstractFactory.LandVehicles;

namespace AppAbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();

        ILandVehicle CreateTransportVehicle();
    }
}
