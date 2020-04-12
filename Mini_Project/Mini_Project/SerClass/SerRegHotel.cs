using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.SerClass
{
    [Serializable]
    public class SerRegHotel
    {
        public string StartLive { get; set; }
        public string EndLive { get; set; }
        public string Desclive { get; set; }

        public SerRegHotel(string startlive, string endlive, string desclive) 
        {
            this.StartLive = startlive;
            this.EndLive = endlive;
            this.Desclive = desclive;
        }

    }
}
