using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.Listing2
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
  }
}