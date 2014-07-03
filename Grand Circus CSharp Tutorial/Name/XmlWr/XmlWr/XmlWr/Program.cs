using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace XmlWr
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("test-doc.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");

            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value);
                userNode.Attributes["age"].Value = (age + 1).ToString();

            }
            xmlDoc.Save("test-doc.xml");



        }
    }
}
