using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RequestAPI.Models
{
    public class XmlContentModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string PublicationYear { get; set; }
        public bool IsAvailable { get; set; }
        public string CallingNumber { get; set; }


    }
}
