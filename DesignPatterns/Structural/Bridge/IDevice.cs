using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    interface IDevice
    {

        bool IsEnabled();
        void Enable();
        void Disable();
        double GetVolume();
        void SetVolume(double percent);
        int GetChannel();
        void SetChannel(int channel);

    }
}
