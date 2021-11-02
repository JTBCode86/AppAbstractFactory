using System;
using AppAbstractFactory.App;
using AppAbstractFactory.Factories;

namespace AppAbstractFactory
{
    class Program
    {
        static Application ConfigureApplication() 
        {
            Application app;
            ITransportFactory transportFactory;

            string company = "Uber";
            if (company.Equals("Uber"))
            {
                transportFactory = new UberTransport();
            }
            else if (company.Equals("99"))
            {
                transportFactory = new NineNineTransport();
            }
            else 
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);
            return app;
        }
        
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();
            app.StartRoute();

            Console.ReadLine();
        }
    }
}
