using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    class LoggerHandler : BaseHandler
    {
        public override Response Handle(Request request)
        {

            Console.WriteLine($"Request {request.RequestURL} being processed with Auth Token {request.AUTHToken}");
            return base.Handle(request);

        }

    }
}
