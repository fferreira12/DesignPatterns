using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    interface ISocialNetworkState
    {
        bool Login(int pass);
        bool Logout();
        bool Post();
    }
}
