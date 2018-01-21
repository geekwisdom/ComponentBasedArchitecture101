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
            typeof(HotelReservationRequestInterface),
            "ResReq",
            WellKnownObjectMode.SingleCall);
            Console.WriteLine(
            "Reservation Server Started...\nPress <enter> to exit.");
            Console.ReadLine();
        }
    }
}