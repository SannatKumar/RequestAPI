using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RequestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class XmlContentController : ControllerBase
    {
        public List<XmlContentModel> XmlContentList = new List<XmlContentModel>()
        {
            new XmlContentModel{ Id = 1, Title = "Harry Potter", Author= "Jk Rowling", PublicationYear = "2001", IsAvailable = true, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 2, Title = "Palpasa Cafe", Author= "Nepali Didi", PublicationYear = "2006", IsAvailable = true, CallingNumber = "9841511118"},
            new XmlContentModel{ Id = 3, Title = "The curious case", Author= "Fitzgerald", PublicationYear = "1965", IsAvailable = true, CallingNumber = "9852653165"},
            new XmlContentModel{ Id = 4, Title = "Eleven Minutes", Author= "Paulo Coelho", PublicationYear = "2004", IsAvailable = true, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 5, Title = "By the river piedra", Author= "paulo Coelho", PublicationYear = "2002", IsAvailable = true, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 6, Title = "Muna madan", Author= "Laxmi Prasad Devkota", PublicationYear = "1994", IsAvailable = false, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 7, Title = "Timro preet ko kura", Author= "Raj Kumar", PublicationYear = "2017", IsAvailable = false, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 8, Title = "K Nepal sano chha", Author= "Laxmi Prasad Devkota", PublicationYear = "1989", IsAvailable = true, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 9, Title = "Veda", Author= "Veda Vyasa", PublicationYear = "100", IsAvailable = true, CallingNumber = "0448427068"},
            new XmlContentModel{ Id = 10, Title = "Ramayan", Author= "Valmiki", PublicationYear = "565", IsAvailable = true, CallingNumber = "0448427068"}
        };

        [HttpGet]
        public ActionResult<IEnumerable<XmlContentModel>> GetAllXmlContentList()
        {
            return XmlContentList;
        }

        [HttpGet("{id}")]
        public ActionResult<XmlContentModel> GetXmlContentList(int id)
        {
            var XmlContentModel = XmlContentList.FirstOrDefault(x => x.Id == id);
            if(XmlContentModel == null)
            {
                return NotFound();
            }
            return XmlContentModel;
        }
    }
}
