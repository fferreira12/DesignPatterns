using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    class LoggedIn : ISocialNetworkState
    {
        SocialNetworkContext context;

        public LoggedIn(SocialNetworkContext context)
        {
            setContext(context);
        }

        public bool Login(int pass)
        {
            Console.WriteLine("You are already logged in. Log out to log in to a different account");
            
            return false;
        }

        public bool Logout()
        {
            Console.WriteLine("Logout Sucessful");
            context.ChangeState(context.LOGGED_OUT_STATE);
            return true;
        }

        public bool Post()
        {
            Console.WriteLine("Posting to logged in account");
            return true;
        }

        void setContext(SocialNetworkContext context)
        {
            this.context = context;
        }
    }
}
