using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using RemotingServer;
namespace RemotingClient
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpChannel tcpChannel = new TcpChannel(8002);
            ChannelServices.RegisterChannel(tcpChannel);

            Service service = (Service)Activator.GetObject(typeof(Service),
                "tcp://localhost:8089/OurFirstRemoteService");
       
            Console.WriteLine(service.SayHello("  Remote"));
            Console.WriteLine(service.HighestNumber(20, 25));
            Console.Read();
        }
    }
}