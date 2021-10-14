using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestAPI.Models;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace RequestAPI.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class XmlContentController : ControllerBase
    {
        public List<ActiveCMSMonitor> XmlContentList = new List<ActiveCMSMonitor>() {
            new ActiveCMSMonitor{ MonitorEvent = "FielSystemEvent", Folder = "C:/txt", Filter = "HR.txt", Action = "TextAction", Property = "Text Property", Query = "Select * from customers" }
        };
        [HttpGet]
        public ActionResult<IEnumerable<ActiveCMSMonitor>> GetAllXmlContentList()
        {



            return XmlContentList;
        }
        /*
        [HttpGet("{id}")]
        public ActionResult<XmlContentModel> GetXmlContentList(int id)
        {
            var XmlContentModel = XmlContentList.FirstOrDefault(x => x.Id == id);
            if (XmlContentModel == null)
            {
                return NotFound();
            }
            return XmlContentModel;
        }
        */
        //Working Post Method
        [EnableCors]
        [Route("content")]
        [HttpPost]
        public  ActionResult<IEnumerable<ActiveCMSMonitor>> PostContentList(ActiveCMSMonitor ContentList)
        {
            
            XmlContentList.Add(ContentList);
            return XmlContentList;

        }
        //*/
        /*[Route("content")]
        [HttpPost]
        
        public async Task<ActionResult<XmlContentModel>> PostContentList(XmlContentModel ContentList)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Aventra_task\conf - examples.xml");
            XmlNode root = doc.SelectSingleNode("ActiveCMSMonitor");
            XmlElement monitorEvent = doc.CreateElement(ContentList.Title);
            root.AppendChild(monitorEvent);
            await doc.Save(@"D:\Aventra_task\conf - examples.xml");
            return Content(ContentList.Title);

        }*/


    }
}
