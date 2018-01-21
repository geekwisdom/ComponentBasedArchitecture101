//Reservatin Client
using System;
using System.IO;
// This class exists only to house the entry point.
class HotelReservationClient {
   // The static method, Main, is the application's entry point.
   public static void Main() {
      // Write text to the console.
      string RequestFile="ResReq.txt";  // file containing the new request
      string ReservationLine=getRequestDetails();
      DoReservation(ReservationLine,RequestFile);
      
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


    public static void DoReservation(string ReservationLine,string FileName)
	{
	using (StreamWriter sw = File.AppendText(FileName)) 
          {
            sw.WriteLine(ReservationLine);
          }	
	}

   }


