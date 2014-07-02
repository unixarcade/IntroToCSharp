using System;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/euroxref/euroxref-daily.xml");
            while(xmlReader.Read())
            {
                if(xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
            if (xmlReader.HasAttributes)
                Console.WriteLine(xmlReader.GetAttribute( "currency" + ": " + xmlReader.GetAttribute("rate"));
        }}
        Console.ReadKey();

        }
    } 
               }
    
