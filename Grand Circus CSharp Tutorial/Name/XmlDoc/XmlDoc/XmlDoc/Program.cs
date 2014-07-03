using System;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDoc
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNode titleNode = xmlDoc.SelectSingleNode("//rss/channel/title");

            if(titleNode != null){
                Console.WriteLine(titleNode.InnerText);
            }

            Console.ReadKey();
        
        
        }
    }
}
