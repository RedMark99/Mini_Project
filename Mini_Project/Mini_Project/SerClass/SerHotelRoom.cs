using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.SerClass
{
    [Serializable]
    public class SerHotelRoom
    {
        public string nomer { get; set; }
        public string countPeople { get; set; }
        public string category { get; set; }
        public string payment { get; set; }

        public SerRegHotel SerRegHotel { get; set; }

        public SerHotelRoom() { }

        public SerHotelRoom(string nomer, string countPeople, string category, string payment) 
        {
            this.nomer = nomer;
            this.countPeople = countPeople;
            this.category = category;
            this.payment = payment;
        }

    }
}
