using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Chain_Of_Responsibility
{
    abstract class DataObject
    {
        Dictionary<string, string> Data;

        public DataObject()
        {
            Data = new Dictionary<string, string>();
        }

        public void SetValue(string key, string data)
        {
            Data[key] = data;
        }

        public string GetValue(string key)
        {
            return Data[key];
        }
    }
}
