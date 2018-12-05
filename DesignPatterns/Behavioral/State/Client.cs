using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.State
{
    class Client
    {

        public static void Main(string[] args)
        {

            SocialNetworkContext facebook = new SocialNetworkContext();

            facebook.Post();
            facebook.Post();

            facebook.Login(120);
            facebook.Login(120);
            facebook.Login(120);
            facebook.Login(120);
            facebook.Login(123);

            facebook.Post();

            facebook.Logout();

            facebook.Logout();

            Console.ReadKey();

        }

    }
}
