using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

namespace NorthWind.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUserActionWriter Writer = new ConsoleWriter();

            AppLogger Logger = new AppLogger(Writer);
            Logger.WriteLog("Application started!!");

            ProductService Service = new ProductService(Writer);
            Service.Add("Emmanuel", "Azucar");

            /*
             * AppLogger y los writers : REsponsabilidad única
             * Apploger: Abierto pero cerrado
             * AppLogger: Inversión de dependencias. Los modulos
             * de alto nivel son independientes de los detalles de implementación
             */
        }
    }
}
