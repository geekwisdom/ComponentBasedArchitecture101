// Example Server that Monitors for a file 'reservation-request' and processes reservations
using System;
using System.IO;
using TravelManagementSystem;
// This class exists only to house the entry point.
namespace TravelManagementSystem
 {
public class HotelReservationRequestInterface : MarshalByRefObject {
  

public void MakeReservation(string ReservationLine)
       {
        String ReservationDB="reservations.txt";
        HotelReservationRequest ResReq = new HotelReservationRequest();
        ResReq.MakeReservation(ReservationLine,ReservationDB);      
 }
}
}