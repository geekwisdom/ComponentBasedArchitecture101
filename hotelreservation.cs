using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.HotelReservation
{
    public class HotelReservationObj
    {
     
     public void MakeReservation(string ClientName, string CheckInDt, string CheckOutDt)
	{
	Console.WriteLine ("Okay: Reserveration Made for " + ClientName + " Check in at: " + CheckInDt + " and Check out by: " + CheckOutDt);
	}

      }
 
}