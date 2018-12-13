using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Television : IDevice
    {

        bool isEnabled = false;
        int channel = 0;
        int volume = 0;

        public void Disable()
        {
            Console.WriteLine("Disabling TV");
            isEnabled = false;
        }

        public void Enable()
        {
            Console.WriteLine("Enabling TV");
            isEnabled = true;
        }

        public int GetChannel()
        {
            Console.WriteLine($"Current Channel is {channel}");
            return channel;
        }

        public double GetVolume()
        {
            Console.WriteLine($"Current Volume is {volume}");
            return volume;
        }

        public bool IsEnabled()
        {
            Console.WriteLine($"TV is on: {isEnabled}");
            return isEnabled;
        }

        public void SetChannel(int channel)
        {
            Console.WriteLine($"Changing channel to : {channel}");
            this.channel = channel;
        }

        public void SetVolume(double percent)
        {
            volume = (int)percent;
            Console.WriteLine($"Changing volume to : {volume}");
        }
    }
}
