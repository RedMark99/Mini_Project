using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Project.XMLClass
{
    [XmlRoot(ElementName = "HOTELROOM")]
    public class HotelRoomXML
    {

        [XmlElement(ElementName = "nomer")]
        public string Nomer { get; set; }

        [XmlElement(ElementName = "countPeople")]
        public string CountPeople { get; set; }

        [XmlElement(ElementName = "category")]
        public string Category { get; set; }

        [XmlElement(ElementName = "payment")]
        public string Payment { get; set; }

        [XmlElement(ElementName = "REGHOTELS")]
        public List<RegHotelXML> REGHOTELS { get; set; }
    }
}
