using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Components.Menu;

namespace Listing4
  {
    class RPCServer
    {
        static void Main(string[] args)
        {
             TcpChannel serverChannel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(serverChannel,false);
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(MenuSystem),
            "Simple",
            WellKnownObjectMode.SingleCall);
            Console.WriteLine(
            "Press <enter> to exit.");
            Console.ReadLine();
        }
    }
}