using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Radio : IDevice
    {

        bool isEnabled = false;
        int channel = 0;
        int volume = 0;

        public void Disable()
        {
            Console.WriteLine("Disabling Radio");
            isEnabled = false;
        }

        public void Enable()
        {
            Console.WriteLine("Enabling Radio");
            isEnabled = true;
        }

        public int GetChannel()
        {
            Console.WriteLine($"Current station is {channel}");
            return channel;
        }

        public double GetVolume()
        {
            Console.WriteLine($"Current Volume is {volume}");
            return volume;
        }

        public bool IsEnabled()
        {
            Console.WriteLine($"Radio is on: {isEnabled}");
            return isEnabled;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Changing Station to : {channel}");
            this.channel = channel;
        }

        public void SetVolume(double percent)
        {
            volume = (int)percent;
            Console.WriteLine($"Changing volume to : {volume}");
        }
    }
}
