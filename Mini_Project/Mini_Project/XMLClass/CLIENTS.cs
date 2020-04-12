using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Mini_Project.XMLClass
{
    [XmlRoot(ElementName = "CLIENTS")]
    public class CLIENTS
    {
        [XmlElement(ElementName = "CLIENT")]
        public List<ClientXML> CLIENT { get; set; }
    }
}
