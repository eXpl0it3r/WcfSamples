using System;

namespace NetFrameworkServer
{
    public class EchoService : IEchoService
    {
        public string Echo(string message)
        {
            Console.WriteLine($"Client sent: {message}");
            return message;
        }
    }
}