using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project.SerClass
{
    [Serializable]
    public class SerClient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string SeriaPassport { get; set; }
        public string NumberPassport { get; set; }
        public string Deschotel { get; set; }
        public string CountDaysLive { get; set; }
        public string DateOfBirth { get; set; }
        public SerHotelRoom SerHotelRoom { get; set; }

        public SerClient() { }

        public SerClient(string name, string surname, string lastname, string login, string password, string seriapassport, string numberpassport, string deschotel, string countdayslive, string dateofbirth) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Lastname = lastname;
            this.Login = login;
            this.Password = password;
            this.SeriaPassport = seriapassport;
            this.NumberPassport = numberpassport;
            this.Deschotel = deschotel;
            this.CountDaysLive = countdayslive;
            this.DateOfBirth = dateofbirth;

        }

    }
}
