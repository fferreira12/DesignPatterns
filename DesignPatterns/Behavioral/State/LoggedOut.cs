using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    class LoggedOut : ISocialNetworkState
    {
        SocialNetworkContext context;

        public LoggedOut(SocialNetworkContext context)
        {
            setContext(context);
        }

        public bool Login(int pass)
        {
            if(pass == 123) { 
                Console.WriteLine("Login Sucessfull");
                context.ChangeState(context.LOGGED_IN_STATE);
                return true;
            } else
            {
                Console.WriteLine("Wrong Password.");
                return false;
            }
        }

        public bool Logout()
        {
            Console.WriteLine("Already Logged Out");
            return false;
        }

        public bool Post()
        {
            Console.WriteLine("Can't do Post while Logged out. Login first.");
            return true;
        }

        void setContext(SocialNetworkContext context)
        {
            this.context = context;
        }
    }
}
