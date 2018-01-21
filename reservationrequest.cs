// Example Server that Monitors for a file 'reservation-request' and processes reservations
using System;
using System.IO;
using TravelManagementSystem;
// This class exists only to house the entry point.
namespace TravelManagementSystem
 {
public class HotelReservationRequest {
   // The static method, Main, is the application's entry point.

public void ProcessReservation(string RequestFile, string ReserveDB)
	{
	Console.WriteLine("Okay, processing " + RequestFile + "...");
	string[] lines = System.IO.File.ReadAllLines(RequestFile);	
 	foreach (string line in lines)
	{
	 MakeReservation(line,ReserveDB);
	}

	}

public void MakeReservation(string ReservationLine,string ReserveDB)
       {
         string[] ReservationDetails = ReservationLine.Split(' ');
	 string avail_room = getroomnumber(ReserveDB,ReservationDetails[0]);
	 updatedb(ReserveDB,avail_room + " " + ReservationLine);
       }

private string getroomnumber(string filename,string checkindate)
	{
	//read the file and find a room number to assign for a given checkindate
	if (!(File.Exists(filename))) return "1"; //if hotel is empty give them the first room
	int RoomNumber=1;
	string[] lines = System.IO.File.ReadAllLines(filename);

 	foreach (string line in lines)
        {
            //Break the line up into room number, checkindate, checkout date, and client info
	    string[] ReservationDetails = line.Split(' ');
	    if (checkindate.Equals(ReservationDetails[1])) RoomNumber++;

        }
	return Convert.ToString(RoomNumber);
	
	}

  private void updatedb(string filename,string linetoappend)
	{
	//Append the line to the end of file
  	using (StreamWriter sw = File.AppendText(filename)) 
        {
            sw.WriteLine(linetoappend);
        }	

	}
}
}