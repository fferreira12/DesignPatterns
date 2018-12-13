using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    class Remote
    {

        IDevice device;

        public Remote() { }
        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void SetDevice(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            if (device.IsEnabled())
            {
                device.Disable();
            }
            else
            {
                device.Enable();
            }
        }

        public void VolumeDown()
        {
            device.SetVolume(device.GetVolume() - 1);
        }

        public void VolumeUp()
        {
            device.SetVolume(device.GetVolume() + 1);
        }

        public void ChannelDown()
        {
            device.SetChannel(device.GetChannel() - 1);
        }

        public void ChannelUp()
        {
            device.SetChannel(device.GetChannel() + 1);
        }
    }
}
