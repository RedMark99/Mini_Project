using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.XMLClass
{
    public class RegTest
    {
        public int idClient { get; set; }
        public int idFlat { get; set; }
        public string StartLive { get; set; }
        public string EndLive { get; set; }
        public string Desclive { get; set; }

        public RegTest(int idClient, int idFlat, string StartLive, string EndLive, string Desclive) 
        {
            this.idClient = idClient;
            this.idFlat = idFlat;
            this.StartLive = StartLive;
            this.EndLive = EndLive;
            this.Desclive = Desclive;
        }
    }
}
