using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation
{
    class Program
    {
     
        static void Main(string[] args)
        {
            CallHotels();
            AbseronRoomsReserved aroomReserv = new AbseronRoomsReserved();
            HiltonRoomsReserved hroomreserv = new HiltonRoomsReserved();
           
            RoomList rooms = new RoomList();
           
            int? SelectHotel = int.Parse(Console.ReadLine());
            bool checker = true;
            while (checker)
            {
                
                if (SelectHotel == 1  )
                {
                    Console.WriteLine(rooms.roomList());
                    Console.WriteLine("Please select your Room (1, 2 or 3) ");

                    int? selectRoom = int.Parse(Console.ReadLine());

                    if (selectRoom == 1 && selectRoom != null)
                    {
                        if (aroomReserv.aSroom == false)
                        {
                            Console.WriteLine(rooms.sroomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if (reserve == "YES")
                            {
                                aroomReserv.aSroom = true;
                                Congratulation();
                            }
                            else if (reserve == "NO")
                            {
                                aroomReserv.aSroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;

                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }

                    }
                    else if (selectRoom == 2)
                    {

                        if(aroomReserv.aDroom == false)
                        {
                            Console.WriteLine(rooms.droomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if(reserve == "YES")
                            {
                                aroomReserv.aDroom = true;
                                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                                Console.WriteLine("Congratulations, You are succesfully reserved");
                                Console.WriteLine(  );
                                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                            }
                            else if(reserve == "NO")
                            {
                                aroomReserv.aDroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;

                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }

                        
                       

                    }
                    else if (selectRoom == 3)
                    {
                        if (aroomReserv.aTroom == false)
                        {
                            Console.WriteLine(rooms.troomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if (reserve == "YES")
                            {
                                aroomReserv.aTroom = true;
                                Congratulation();
                            }
                            else if (reserve == "NO")
                            {
                                aroomReserv.aTroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;

                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Something is wrong");
                        return;
                    }
                }
                else if (SelectHotel == 2 )
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(rooms.HiltonRoomList());
                    int HselectRoom = int.Parse(Console.ReadLine());

                    if (HselectRoom == 1)
                    {
                        if (hroomreserv.hSroom == false)
                        {
                            Console.WriteLine(rooms.hsroomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if (reserve == "YES")
                            {
                                hroomreserv.hSroom = true;
                                Congratulation();

                            }
                            else if (reserve == "NO")
                            {
                                hroomreserv.hSroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }

                    }
                    else if (HselectRoom == 2)
                    {
                        if (hroomreserv.hDroom == false)
                        {
                            Console.WriteLine(rooms.hdroomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if (reserve == "YES")
                            {
                                hroomreserv.hDroom = true;
                                Congratulation();

                            }
                            else if (reserve == "NO")
                            {
                                hroomreserv.hDroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;

                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }
                    }
                    else if (HselectRoom == 3)
                    {
                        if (hroomreserv.hTroom == false)
                        {
                            Console.WriteLine(rooms.htroomPriceList());
                            Console.WriteLine("Do you want to reservation this room? (yes or no )");
                            string reserve = (Console.ReadLine()).ToUpper();

                            if (reserve == "YES")
                            {
                                hroomreserv.hTroom = true;
                                Congratulation();

                            }
                            else if (reserve == "NO")
                            {
                                hroomreserv.hTroom = false;
                            }
                            else
                            {
                                Console.WriteLine("Something is wrong");
                                return;

                            }
                        }
                        else
                        {
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("This room is already reserved, Plese select other room");
                            Console.WriteLine();
                            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        }
                    }
                    else
                    {
                        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                        Console.WriteLine("Something is wrong please try again");
                        Console.WriteLine();
                        Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");

                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Someting is wrong");
                    return;
                }
            }
            
        }

        static void CallHotels()
        {
            Console.WriteLine("Welcome to Our reservation");
            Console.WriteLine("==========================================");
            Console.WriteLine();
            Hotels hotelList = new Hotels();
            Console.WriteLine(hotelList.HotelList());
            Console.WriteLine("Please select your hotel (1 or 2) ");
        }

        static void Congratulation()
        {
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("Congratulations, You are succesfully reserved");
            Console.WriteLine();
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
        }

    }




    public class AbseronRoomsReserved
    {
        public bool aSroom = false;
        public bool aDroom = false;
        public bool aTroom = false;
    }

    public class HiltonRoomsReserved
    {
        public bool hSroom = false;
        public bool hDroom = false;
        public bool hTroom = false;
    }
}
