using System.Runtime.Serialization;
using System.ServiceModel;

namespace NetClient
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string Echo(string message);
    }

    [DataContract]
    public class EchoMessage
    {
        [DataMember]
        public string Message { get; set; }
    }
}