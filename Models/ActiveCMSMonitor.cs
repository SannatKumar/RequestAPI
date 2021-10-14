using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace RequestAPI.Models
{
    public class ActiveCMSMonitor
    {
        //[XmlIgnore]
        //public int Id { get; set; }
        public string MonitorEvent { get; set; }
        public string Folder { get; set; }
        public string Filter { get; set; }
        public string Action { get; set; }
        public string Property { get; set; }
        public string Query { get; set; }

        public void Save()
        {
            
        }
    }
}
