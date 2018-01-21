using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Components.Menu
{
    public class MenuSystem : MarshalByRefObject
    {
     public string showmenu(string filename)
	{
	String Result="";
	if (File.Exists(filename))
          {
            string[] readText = File.ReadAllLines(filename);
            
	    foreach (string s in readText)
        	{
                 Result = Result + s + "\n";
        	}
        }
      return Result;
	}
  }
}