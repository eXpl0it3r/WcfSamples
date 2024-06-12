using System.ServiceModel;
using NetClient;

const string namedPipe = "net.pipe://localhost/Sample/EchoEndpoint";
var endpoint = new EndpointAddress(namedPipe);
var pipe = new NetNamedPipeBinding
{
    ReceiveTimeout = TimeSpan.MaxValue,
    SendTimeout = TimeSpan.MaxValue
};
var channelFactory = new ChannelFactory<IEchoService>(pipe, endpoint);

channelFactory.Open();

try
{
    var client = channelFactory.CreateChannel();
    
    Console.WriteLine("Exit by typing 'quit'");
    string input; 
    
    do
    {
        Console.Write("Send: ");
        input = Console.ReadLine();
        var response = client.Echo(input);
        Console.WriteLine($"Echo: {response}");

    } while (input != "quit");
}
finally
{
    channelFactory.Close();
}