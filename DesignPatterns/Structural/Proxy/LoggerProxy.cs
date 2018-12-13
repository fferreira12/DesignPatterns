using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    class LoggerProxy : IService
    {

        IService serviceInstance = new RandomVowelService();

        public string GetData()
        {
            string vowel = serviceInstance.GetData();
            Console.WriteLine($"Client requested a Vowel and got a {vowel}");
            return vowel;
        }
    }
}
