
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation
{
     public class Hotel
    {
        public string Name;
        public string Address;
        public decimal MinimumPrice;
        public string Service;
    }

    public class Abseron : Hotel
    {
        public string abseronHotel()
        {
            Name = "Abseron Hotel";
            Address = "Azadliq meydani, Baku 1000";
            Service = "Free Transport, Lunch,Dinner";
            MinimumPrice = 120;

            return "Hotel: " + Name + "\n" +
                "Address: " + Address + "\n" +
                "Minimum Price: " +MinimumPrice + " Azn" + "\n" +
                "Service: " + Service;
        }
    }

    public class Hilton : Hotel
    {
        public string hiltonHotel()
        {
            Name = "Hilton Hotel";
            Address = "1B Azadliq meydani, Baku";
            Service = "Free Transport, Lunch,Dinner";
            MinimumPrice = 250;

            return "Hotel: " + Name + "\n" +
                "Address: " + Address + "\n" +
                 "Minimum Price: " + MinimumPrice + " Azn" + "\n" +
                "Service: " + Service;
        }
    }


    public class Hotels
    {
        Abseron abseron = new Abseron();
        Hilton hilton = new Hilton();

        public string HotelList()
        {
            return "1.\n"+ abseron.abseronHotel() + "\n" + "===================" + "\n" + "2.\n" + hilton.hiltonHotel();
        }
    }
}
