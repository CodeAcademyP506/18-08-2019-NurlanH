using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation
{
    public class Room
    {
        public string roomName;
        public int RoomCount;
        public decimal RoomPrice;
        public string RoomInfo;
    }

    public class singleRoom : Room
    {
       
        public string sroomPrice()
        {
            roomName = "Single";
            RoomPrice = 120;

            return roomName + " " + RoomPrice + " Azn";
        }

        

        public string sroomInfo()
        {
            RoomCount = 1;
            RoomInfo = "Free wifi,Drink";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " + RoomPrice + " Azn";
        }
    }

    public class doubleRoom : Room
    {
        public string droomPrice()
        {
            roomName = "Double";
            RoomPrice = 250;

            return roomName + " " + RoomPrice + " Azn";
        }

        public string droomInfo()
        {
            RoomCount = 2;
            RoomInfo = "Free wifi,Drink,Disco";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " +RoomPrice + " Azn";
        }
    }

    public class tripleRoom : Room
    {
        public string troomPrice()
        {
            roomName = "Triple";
            RoomPrice = 500;

            return roomName  + " " +  RoomPrice + " Azn";
        }

        public string troomInfo()
        {
            RoomCount = 3;
            RoomInfo = "Free wifi, Drink, Party, Massage, Netflix";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " + RoomPrice + " Azn";
        }
    }

    public class hiltonSingle : Room
    {

        public string hsroomPrice()
        {
            roomName = "Single";
            RoomPrice = 250;

            return roomName + " " + RoomPrice + " Azn";
        }

        public string hsroomInfo()
        {
            RoomCount = 1;
            RoomInfo = "Free wifi,Drink";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " + RoomPrice + " Azn";
        }
    }


    public class hiltonDouble : Room
    {

        public string hdroomPrice()
        {
            roomName = "Double";
            RoomPrice = 350;

            return roomName + " " + RoomPrice + " Azn";
        }

        public string hdroomInfo()
        {
            RoomCount = 2;
            RoomInfo = "Free wifi,Drink";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " + RoomPrice + " Azn";
        }
    }

    public class hiltonTriple : Room
    {

        public string htroomPrice()
        {
            roomName = "Triple";
            RoomPrice = 700;

            return roomName + " " + RoomPrice + " Azn";
        }

        public string htroomInfo()
        {
            RoomCount = 3;
            RoomInfo = "Free wifi,Drink";
            return "Room Count: " + RoomCount + "\n" + "Room info: " + RoomInfo + "\n" + "Room Price: " + RoomPrice + " Azn";
        }
    }


    public class RoomList
    {
        singleRoom sroom = new singleRoom();
        doubleRoom droom = new doubleRoom();
        tripleRoom troom = new tripleRoom();
        hiltonSingle hsroom = new hiltonSingle();
        hiltonDouble hdroom = new hiltonDouble();
        hiltonTriple htroom = new hiltonTriple ();

        public string roomList()
        {
            return sroom.sroomPrice() +  "\n" + droom.droomPrice() + "\n" + troom.troomPrice();
        }
        
        public string sroomPriceList()
        {
            return sroom.sroomInfo();
        }

        public string droomPriceList()
        {
            return  droom.droomInfo();
        }

        public string troomPriceList()
        {
            return troom.troomInfo();
        }

        public string HiltonRoomList()
        {
            return hsroom.hsroomPrice() + "\n" + hdroom.hdroomPrice() + "\n" + htroom.htroomPrice();
        }

        public string hsroomPriceList()
        {
            return hsroom.hsroomInfo();
        }

        public string hdroomPriceList()
        {
            return hdroom.hdroomInfo();
        }

        public string htroomPriceList()
        {
            return htroom.htroomInfo();
        }
    }
}
