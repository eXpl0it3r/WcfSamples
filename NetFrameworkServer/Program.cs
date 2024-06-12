using System;
using System.ServiceModel;

namespace NetFrameworkServer
{
    internal static class Program
    {
        public static void Main()
        {
            const string namedPipe = "net.pipe://localhost/Sample";
            var host = new ServiceHost(typeof(EchoService), new Uri(namedPipe));
            host.AddServiceEndpoint(typeof(IEchoService), new NetNamedPipeBinding(), "EchoEndpoint");
            host.Open();
            
            Console.WriteLine("Press enter to close the server");
            Console.ReadLine();

            host.Close();
        }
    }
}