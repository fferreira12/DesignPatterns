using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Observer
{
    class FileLogger : ISubscriber
    {
        string FileName { get; set; }

        public FileLogger(string fileName)
        {
            FileName = fileName;
        }

        public void Update(string message)
        {
            
            using (StreamWriter file =
                new StreamWriter(FileName, true))
            {
                file.WriteLine(message);
            }
            
        }
    }
}
