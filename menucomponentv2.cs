using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.TravelManagementSystem
{
    public class MenuSystem
    {
     public static void showmenu(string filename)
	{
	if (File.Exists(filename))
          {
            var origcolor = Console.ForegroundColor;
	    Console.ForegroundColor = ConsoleColor.Green;          
            string[] readText = File.ReadAllLines(filename);
            foreach (string s in readText)
        	{
            Console.WriteLine(s);
        	}
         Console.ForegroundColor = origcolor;  
	}
      }
public static void DoHotelReservation()
	{
	Console.WriteLine("\nMaking Hotel Reservation Request\n");
	Console.WriteLine("Enter Client Name: ");
	String ClientName = Console.ReadLine();
	Console.WriteLine("Enter Check In Date: ");
	String CheckInDate = Console.ReadLine();
	Console.WriteLine("Enter Check Out Date: ");
	String CheckOutDate = Console.ReadLine();
//	HotelReservationObj HotelReservationSys = new HotelReservationObj();
//	HotelReservationSys.MakeReservation(ClientName,CheckInDate,CheckOutDate);
	System.Threading.Thread.Sleep(5000);
	}

     public static void DoCarReservation()
	{
	Console.WriteLine("Okay, inside DoCarReservation()");
	}
     public static void DoFlightReservation()
	{
	Console.WriteLine("Okay, inside DoFlightReservation()");
	}

  }
}