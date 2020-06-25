using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using Operaciones;

namespace Servidor
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Creación y registro del canal
            ChannelServices.RegisterChannel(new HttpChannel(8090), false);

            //Registramos el objeto remoto
            RemotingConfiguration.ApplicationName = "CalculatorApplication";
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(Operaciones.operaciones), "Operaciones",
            WellKnownObjectMode.SingleCall);

            Console.WriteLine("Pulsa enter para detener el proceso");
            Console.ReadLine();
        }
    }
}
