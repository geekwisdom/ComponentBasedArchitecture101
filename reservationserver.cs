// Example Server that Monitors for a file 'reservation-request' and processes reservations
using System;
using System.IO;
using TravelManagementSystem;
// This class exists only to house the entry point.
class HotelReservationServer {
   // The static method, Main, is the application's entry point.
   public static void Main() {
      // Write text to the console.
      string RequestFile="ResReq.txt";  // file containing the new request
      string ReservationDB="Reservations.txt"; // File where we will store reservations
      Console.WriteLine("Reservation Server Started...");
      HotelReservationRequest ResReq = new HotelReservationRequest();
      while (true) // Loop forever, waiting fora file
	{
	if (File.Exists(RequestFile))
	 {
	   //Yeah we have a new reservation
	   ResReq.ProcessReservation(RequestFile,ReservationDB);
	   //Delete the file when we are done
	   File.Delete(RequestFile);
	 }
	System.Threading.Thread.Sleep(2500); // wait 2.5 seconds
	}
	
   }

}
