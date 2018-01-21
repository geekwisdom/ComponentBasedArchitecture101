using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using TravelManagementSystem;

namespace TravelSystem
{
    class TravelManagementSystem
    {
        static int Main(string[] args)
        {
        string ReservationLine=getRequestDetails();
	DoReservation(ReservationLine,"tcp://localhost:8888/ResReq");
         return 0;
        }
public static string getRequestDetails()
	{
	//get the info and compose it in the proper stirng fromat
	string Result="";
	string CheckInDate="";
	string CheckOutDate="";
	string ReservationName="";
	Console.Write("Enter Check-In Date (YYYY-MM-DD):");
	CheckInDate = Console.ReadLine();
	Console.Write("Enter Check-Out Date (YYYY-MM-DD):");
	CheckOutDate = Console.ReadLine();

	Console.Write("Enter Reservation Name:");
	ReservationName = Console.ReadLine();
	Result=CheckInDate + " " + CheckOutDate + " " + ReservationName;
	return Result;
	}

    public static void DoReservation(string ReservationLine,string Address)
	{
             TcpChannel serverChannel = new TcpChannel();
            ChannelServices.RegisterChannel(serverChannel,false);
       
            HotelReservationRequestInterface MyReservation = null;
            MyReservation = (HotelReservationRequestInterface)Activator.GetObject(
            typeof(HotelReservationRequestInterface),
            Address);
            MyReservation.MakeReservation(ReservationLine);           
            
	}


    }
}