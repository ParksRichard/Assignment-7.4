/*
Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, 
and small, with a fixed number of slots for each size.
Implement the ParkingSystem class:
ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class.
The number of slots for each parking space are given as part of the constructor.
bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot.
carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. 
A car can only park in a parking space of its carType. If there is no space available, return false,
else park the car in that size space and return true. 
*/


//different classes with properties for each car size
//bool an if hten statement for car sizes
//dictionary for tallying how many spacews?
// or enum for specifying parkins space sizes

namespace Assignment_7._4
{
    internal class ParkingSystem
    {

        private int[] slots;

        //initializing objects in the class
        public ParkingSystem(int big, int medium, int small)
        {
            slots = new int[4]; 
            slots[1] = big;
            slots[2] = medium;
            slots[3] = small;
        }

        public bool AddCar(int carType)
        {
            if (slots[carType] > 0)
            {
                slots[carType]--;
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //hardcode input and output example
            ParkingSystem parkingSystem = new ParkingSystem(1, 1, 0);
            Console.WriteLine("How many parking spaces are left?");
            Console.WriteLine("");
            //change from bool to string array?
            Console.WriteLine(parkingSystem.AddCar(1)); 
            Console.WriteLine(parkingSystem.AddCar(2)); 
            Console.WriteLine(parkingSystem.AddCar(3));
            Console.WriteLine(parkingSystem.AddCar(1)); 
        }
    }

    //user input?
}
