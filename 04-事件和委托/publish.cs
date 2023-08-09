using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_事件和委托
{
    delegate void Delegate();
    internal class Publish
    {
        //受限制的委托(只能添加限制，不能直接赋值, 而且只能在类的内部调用)
        public event Delegate Others_Event_Delegate = null;
        public string Name { get; private set; }

        public Publish(string name)
        {
            Name = name;
        }
        public void Event()
        {
            Console.WriteLine($"{Name}去触发Event");
            if (Others_Event_Delegate != null)
            {
                Others_Event_Delegate();
            }
        }
    }
}
