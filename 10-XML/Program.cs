using System.Xml;

namespace _10_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("XMLFile1.xml");

            XmlNode root = xmlDoc.ChildNodes[1];
            XmlNodeList skillist =  root.ChildNodes;
            foreach (XmlNode skill in skillist)
            {
                foreach (XmlNode node in skill.ChildNodes)
                {
                    Console.WriteLine($"{node.Name} : {node.InnerText}");
                }
            }
        }
    }
}