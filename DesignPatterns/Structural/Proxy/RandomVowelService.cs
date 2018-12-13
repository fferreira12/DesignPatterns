using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    class RandomVowelService : IService
    {
        private readonly string[] vowels = new string[] { "A", "E", "I", "O", "U" };
        private Random random = new Random();

        public string GetData()
        {
            return vowels[random.Next(vowels.Length)];
        }
    }
}
