using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Project.XMLClass
{
    [XmlRoot(ElementName = "HOTELROOMS")]
    public class HOTELROOMS
    {

        [XmlElement(ElementName = "HOTELROOM")]
        public List<HotelRoomXML> HOTELROOM { get; set; }

    }
}
