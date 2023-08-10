using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_特性
{
    [AttributeUsage(AttributeTargets.Class)]//指定特性标注的对象
    internal class InformationAttribute : Attribute
    {
        public string developer;
        public string version;
        public string description;

        public InformationAttribute(string developer, string version, string description)
        {
            this.developer = developer;
            this.version = version;
            this.description = description;
        }


    }

}
