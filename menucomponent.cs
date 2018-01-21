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
            
            string[] readText = File.ReadAllLines(filename);
            foreach (string s in readText)
        	{
            Console.WriteLine(s);
        	}
          }
	}
     

      }
 
}