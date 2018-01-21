using System;
using System.Collections.Generic;
using System.Text;

namespace Components.Listing1
{
    public class MyWriteLine
    {
        public static void WriteOut(string Sentence)
        {
	var origcolor=Console.ForegroundColor;
	Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Sentence);
	Console.ForegroundColor = origcolor;
	}
    }
}