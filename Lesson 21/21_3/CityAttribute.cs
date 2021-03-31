using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{ 
    
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class CityAttribute : Attribute 
    {
        private readonly string date;

        public string Date
        {
            get { return date; }
        }
        private readonly string name;

        public string Name
        {
            get { return name; }
        }

        public double Version { get; set; }
        public string Release { get; set; }
        public string System { get; set; }

        public CityAttribute(string data, string name)
        {
            this.date = data;
            this.name = name;
        }
    }
}
