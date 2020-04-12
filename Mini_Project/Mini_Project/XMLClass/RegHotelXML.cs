using Mini_Project.MyDbClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Project.XMLClass
{

    [XmlRoot(ElementName = "REGHOTEL")]

    public class RegHotelXML
    {

        [XmlElement(ElementName = "startLive")]
        public string StartLive { get; set; }

        [XmlElement(ElementName = "endLive")]
        public string EndLive { get; set; }

        [XmlElement(ElementName = "desclive")]
        public string Desclive { get; set; }

    }
}
