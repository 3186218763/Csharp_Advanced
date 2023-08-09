using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_事件和委托
{
    internal class Subscribe
    {
        public string Name { get; private set; }

        public Subscribe(string name)
        {
            Name = name;
        }

        public void Action1()
        {
            Console.WriteLine($"帮助{Name}做Action1");
        }

        public void Action2()
        {
            Console.WriteLine($"帮助{Name}做Action2");
        }
    }
}
