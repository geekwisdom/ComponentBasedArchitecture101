using System;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using TravelManagementSystem;
// This class exists only to house the entry point.

class HotelReservationServer {
   // The static method, Main, is the application's entry point.
   public static void Main() {
        {
             TcpChannel serverChannel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(serverChannel,false);
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(HotelReservationRequest),
            "ResReq",
            WellKnownObjectMode.SingleCall);
            Console.WriteLine(
            "Press <enter> to exit.");
            Console.ReadLine();
        }
    }
}