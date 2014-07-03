using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace XmlSelectNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");

            foreach (XmlNode itemNode in itemNodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");

                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");

                if(((titleNode != null)) && (dateNode != null)){
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);

                }
                
                Console.ReadKey();
            }
        }
    }
}
