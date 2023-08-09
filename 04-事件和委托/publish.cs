using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_事件和委托
{
    internal class publish
    {
        public string Name { get; private set; }

        public publish(string name)
        {
            Name = name;
        }
        public void Event()
        {
            Console.WriteLine($"{Name}去触发Event");
        }
    }
}
