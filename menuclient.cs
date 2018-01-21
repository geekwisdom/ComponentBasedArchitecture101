using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Components.Menu;

namespace TravelSystem
{
    class TravelManagementSystem
    {
        static int Main(string[] args)
        {
             TcpChannel serverChannel = new TcpChannel();
            ChannelServices.RegisterChannel(serverChannel,false);
       
            MenuSystem TheMenu = null;
            TheMenu = (MenuSystem)Activator.GetObject(
            typeof(MenuSystem),
            "tcp://localhost:8888/Simple");
            string ret = null;
            ret = TheMenu.showmenu("menu.txt");
            Console.WriteLine(ret);
            return (0);
        }
    }
}