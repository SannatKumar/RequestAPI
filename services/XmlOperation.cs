using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace RequestAPI.services
{
    public class XmlOperation
    {            
            private readonly static string XMLPath = @"D:\Aventra_task\conf - examples.xml";
            private readonly static XmlOperation _instance = new XmlOperation();


            public XmlDocument XmlDoc { get; set; }

            private XmlOperation()
            {
                XmlDoc = new XmlDocument();
                XmlDoc.Load(XMLPath);
            }

            public static XmlOperation Instance
            {
                get
                {
                    return _instance;
                }
            }
        }
    }


    /*XmlDocument doc = new XmlDocument();
        doc.Load(@"D:\Aventra_task\conf - examples.xml");
            XmlNode root = doc.SelectSingleNode("ActiveCMSMonitor");
        XmlElement monitorEvent = doc.CreateElement(ContentList.Title);
        root.AppendChild(monitorEvent);*/

   
