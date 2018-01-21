// Example Server that Monitors for a file 'reservation-request' and processes reservations
using System;
using System.IO;

// This class exists only to house the entry point.
class HotelReservationServer {
   // The static method, Main, is the application's entry point.
   public static void Main() {
      // Write text to the console.
      string RequestFile="ResReq.txt";  // file containing the new request
      string ReservationDB="Reservations.txt"; // File where we will store reservations
      Console.WriteLine("Reservation Server Started...");
      while (true) // Loop forever, waiting fora file
	{
	if (File.Exists(RequestFile))
	 {
	   //Yeah we have a new reservation
	   ProcessReservation(RequestFile,ReservationDB);
	   //Delete the file when we are done
	   File.Delete(RequestFile);
	 }
	System.Threading.Thread.Sleep(2500); // wait 2.5 seconds
	}
	
   }

  public static void ProcessReservation(string RequestFile, string ReserveDB)
	{
	Console.WriteLine("Okay, processing " + RequestFile + "...");
	string[] lines = System.IO.File.ReadAllLines(RequestFile);	
 	foreach (string line in lines)
	{
         string[] ReservationDetails = line.Split(' ');
	 string avail_room = getroomnumber(ReserveDB,ReservationDetails[0]);
	 updatedb(ReserveDB,avail_room + " " + line);
	}

	}

  private static string getroomnumber(string filename,string checkindate)
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

  private static void updatedb(string filename,string linetoappend)
	{
	//Append the line to the end of file
  	using (StreamWriter sw = File.AppendText(filename)) 
        {
            sw.WriteLine(linetoappend);
        }	

	}
}
