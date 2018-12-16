using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    class AuthHandler : BaseHandler
    {

        public override Response Handle(Request request)
        {
            if (request.AUTHToken == "1234")
            {
                Console.WriteLine("Authentication Successfull");
                return base.Handle(request);
            }
            else
            {
                Response r = new Response();
                Console.WriteLine("Error: Invalid Auth Token Provided");
                r.SetValue("error", "Invalid Auth Token Provided");
                return r;
            }
        }

    }
}
