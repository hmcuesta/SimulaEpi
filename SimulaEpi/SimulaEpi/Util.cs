using System;
using System.Xml.Linq;

namespace SimulaEpi
{
    class Util
    {

        public void writeXML(string xmlPath, Configuration conf)
   {

       XElement xml = new XElement("Configuration",
                                new XElement("transmissionProb", conf.transmissionProb),
                                new XElement("avgContacts", conf.avgContacts),
                                new XElement("latentP", conf.latentP),
                                new XElement("infectiousP", conf.infectiousP),
                                new XElement("recoveriP", conf.recoveriP),
                                new XElement("model", conf.model),
                                new XElement("pointerSel", conf.pointerSel),
                                new XElement("seed", conf.seed)
                                );

       xml.Save(xmlPath);

   }

   public Configuration readXML(string xmlPath)
   {

       XElement xml = XElement.Load(xmlPath);
       Configuration conf = new Configuration();

       conf.transmissionProb = (double)xml.Element("transmissionProb");
       conf.avgContacts = (int)xml.Element("avgContacts");
       conf.infectiousP = (int)xml.Element("infectiousP");
       conf.latentP = (int)xml.Element("latentP");
       conf.model = (int)xml.Element("model");
       conf.recoveriP = (int) xml.Element("recoveriP");
       conf.seed = (int)xml.Element("seed");
       conf.pointerSel = (int)xml.Element("pointerSel");


       return conf;
   
   }


    }
}
