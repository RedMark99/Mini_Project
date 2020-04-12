using Mini_Project.MyDbClass;
using System;
using System.Data.Entity;

namespace Mini_Project
{
    public class MyDbContext : DbContext
    {
        internal object clients;

        public MyDbContext() : base("DbConnectionString")
        {
            
        }

        public DbSet<RegHotel> RegHotels {get; set;}

        public DbSet<Client> Clients {get; set;}

        public DbSet<HotelRoom> HotelRooms {get; set;}



    }
}
