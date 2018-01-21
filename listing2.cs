using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.Listing2
{
    class Program
    {
        static void Main(string[] args)
        {
        //Simple program to output the contents of a file to the screen 
	showmenu("menu.txt");
	}
    

    static void showmenu(string filename)
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