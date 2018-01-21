using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.TravelManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
        //Simple program to output the contents of a file to the screen 
	int done=1;
	while (done != 0)	
		{
		Console.Clear();
		MenuSystem.showmenu("menu.txt");
		String command=Console.ReadLine();
		done=Interpret(command);
		if (done !=0) System.Threading.Thread.Sleep(2500);
		}
	}
    
       static int Interpret(string Sentence)
	{
	if (String.Compare(Sentence,"1") == 0)
	 {
	 MenuSystem.DoHotelReservation();
	 return 1; 
	}
	else if (String.Compare(Sentence,"2") == 0)
	 {
	MenuSystem.DoCarReservation(); 
	return 1;
	}
	else if (String.Compare(Sentence,"3") == 0)
	 {
	MenuSystem.DoFlightReservation(); 
	return 1;
	 }
	else if (String.Compare(Sentence,"4") == 0)
	 {
	 return 0;
	 }
	else
	{
	Console.WriteLine("Bad Command");
	}
	return 1;
	}
  }
}