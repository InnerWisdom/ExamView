using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using FileImplement.Models;

namespace FileImplement
{
    public class FileDataSingleton
    {
        private static FileDataSingleton instance;

        private readonly string PassFileName = "Reis.xml";

        private readonly string ReisFileName = "Pass.xml";

        public List<Reis> Reiss { get; set; }

        public List<Pass> Passs { get; set; }
        private FileDataSingleton()
        {
            Passs = LoadPasss();
            Reiss = LoadReiss();
        }
        public static FileDataSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataSingleton();
            }
            return instance;
        }

        ~FileDataSingleton()
        {
            SavePasss();
            SaveReiss();
        }

        private List<Pass> LoadPasss()
        {
            var list = new List<Pass>();
            if (File.Exists(PassFileName))
            {
                XDocument xDocument = XDocument.Load(PassFileName);
                var xElements = xDocument.Root.Elements("Pass").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Pass
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        name = elem.Element("PassName").Value
                    });
                }
            }
            return list;
        }

        private List<Reis> LoadReiss()
        {
            var list = new List<Reis>();
            if (File.Exists(ReisFileName))
            {
                XDocument xDocument = XDocument.Load(ReisFileName);
                var xElements = xDocument.Root.Elements("Reis").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Reis
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        company = elem.Element("Company").Value
                    });
                }
            }
            return list;
        }

        private void SavePasss()
        {
            if (Passs != null)
            {
                var xElement = new XElement("Passs");
                foreach (var pass in Passs)
                {
                    xElement.Add(new XElement("Pass",
                    new XAttribute("Id", pass.Id),
                    new XElement("PassName", pass.name)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(PassFileName);
            }
        }
        private void SaveReiss()
        {
            if (Reiss != null)
            {
                var xElement = new XElement("Reiss");
                foreach (var reis in Reiss)
                {
                    xElement.Add(new XElement("Reis",
                    new XAttribute("Id", reis.Id),
                    new XElement("Company", reis.company)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ReisFileName);
            }
        }

    }
}
