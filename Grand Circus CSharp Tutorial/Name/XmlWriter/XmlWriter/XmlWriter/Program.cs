using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");



            xmlWriter.WriteEnDocument();
            xmlWriter.Close();


        }
    }
}
