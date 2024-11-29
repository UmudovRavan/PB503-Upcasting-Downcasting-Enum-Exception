using Upcasting_Downcasting_Enum__Exception.Task1;
using Upcasting_Downcasting_Enum__Exception.Task2;

namespace Upcasting_Downcasting_Enum__Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            try
            {
                Room room1 = new Room("atto", 200, 4);
                Room room2 = new Room("otto", 300, 5);

                Hotel hotel = new Hotel("Relax");
                hotel.AddRoom(room1);
                hotel.AddRoom(room2);

                hotel.MakeReservation(room2.Id);
                Console.WriteLine("Room1 reserved");

                //hotel.MakeReservation(room1.Id);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine($"Nul reference error");
            }
            catch (NotAvailableException)
            {
                Console.WriteLine($"Room Not Available");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Argument error");
            }
            catch (Exception)
            {
                Console.WriteLine($"General error");
            }
            finally
            {
                Console.WriteLine("Execution completed.");
            }
            #endregion

            #region Task2
            Car car1 = new Car("Mercedes-Benz","S600",CarType.Sedan);
            Car car2 = new Car("Range-Rover", "Vogue", CarType.SUV);
            Car car3 = new Car("Nissan","GTR",CarType.Sport);


            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car3);

            #endregion

        }
    }
}
