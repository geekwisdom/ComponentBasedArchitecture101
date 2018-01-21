using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.Listing1
{
    class Program
    {
        static void Main(string[] args)
        {
        //Simple program to output the contents of a file to the screen 
	string path="menu.txt";
	if (File.Exists(path))
        {
            
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
        	{
            Console.WriteLine(s);
        	}
        }
	}
    }
}