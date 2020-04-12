using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Project.XMLClass
{

    [XmlRoot(ElementName = "CLIENT")]
    public class ClientXML
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "surname")]
        public string Surname { get; set; }

        [XmlElement(ElementName = "lastname")]
        public string Lastname { get; set; }

        [XmlElement(ElementName = "login")]
        public string Login { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "seriaPassport")]
        public string SeriaPassport { get; set; }

        [XmlElement(ElementName = "numberPassport")]
        public string NumberPassport { get; set; }

        [XmlElement(ElementName = "deschotel")] 
        public string Deschotel { get; set; }

        [XmlElement(ElementName = "countDaysLive")]
        public string CountDaysLive { get; set; }

        [XmlElement(ElementName = "dateOfBirth")]
        public string DateOfBirth { get; set; }

        [XmlElement(ElementName = "HOTELROOM")]
        public List<HotelRoomXML> HOTELROOM { get; set; }

    }
}
