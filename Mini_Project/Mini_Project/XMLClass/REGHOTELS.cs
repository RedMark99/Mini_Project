using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mini_Project.XMLClass
{
    [XmlRoot(ElementName = "REGHOTELS")]
    public class REGHOTELS
    {

        [XmlElement(ElementName = "REGHOTEL")]
        public List<RegHotelXML> REGHOTEL { get; set; }

    }
}
