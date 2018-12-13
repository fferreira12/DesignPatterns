using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Client
    {

        public static void Main(string[] args)
        {

            Remote remote = new Remote();

            remote.SetDevice(new Television());

            remote.TogglePower();

            remote.ChannelUp();
            remote.ChannelUp();
            remote.ChannelDown();

            remote.VolumeUp();
            remote.VolumeUp();
            remote.VolumeDown();

            remote.TogglePower();
            remote.TogglePower();

            remote.SetDevice(new Radio());

            remote.TogglePower();

            remote.ChannelUp();
            remote.ChannelUp();
            remote.ChannelDown();

            remote.VolumeUp();
            remote.VolumeUp();
            remote.VolumeDown();

            remote.TogglePower();
            remote.TogglePower();

            Console.ReadKey();
        }
    }
}
