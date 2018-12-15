using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    class PageHandler : BaseHandler
    {

        public override Response Handle(Request request)
        {
            if (request.RequestURL == "/main")
            {
                Response r = new Response();
                Console.WriteLine("Providing /main");
                r.SetValue("/main", "Main Page");
                return r;
            }
            else
            {
                Response r = new Response();
                Console.WriteLine("Error: Page Not Found");
                r.SetValue("error", "Page Not Found");
                return r;
            }

        }

    }
}
