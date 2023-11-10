using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                int temp = 0;
                while (temp==0)
                {
                    Console.WriteLine("Choos your Interior Interface \n1 Press for Car \n2 Press for MotorCycle");
                    VehicleType vehicletype=(VehicleType)int.Parse(Console.ReadLine());
                    if (vehicletype==(VehicleType)1 || vehicletype==(VehicleType)2 )
                    {
                        if (vehicletype == (VehicleType)1)
                        {
                            CarSystem();
                        }
                        else
                        {
                            MotorCycleSystem ();
                        }
                        temp = 1;
                    }
                    else
                    {
                        Console.WriteLine("Plese ente 1 or 2");
                        temp = 0; 
                    }
                }
            
            
        }
        public static void CarSystem()
        {
            
            Console.Write("MODEL NO: ");
            string modelno=(Console.ReadLine());
            Console.Write("YEAR MAKE: ");
            int yearmake=int.Parse(Console.ReadLine());
            Console.Write("NUMBER OF SEATS: ");
            int seats=int.Parse(Console.ReadLine());
            Console.Write("NUMBER OF GEAR: ");
            int gear=int.Parse(Console.ReadLine());
            Console.Write("NUMBER OF DOOR: ");
            int door=int.Parse(Console.ReadLine());
            Console.Write("MAXIMUM CAPACITY CC: ");
            int capacityCC=int.Parse(Console.ReadLine());
            Console.Write("STEARING SYSTEM: ");
            string stearingSystem=Console.ReadLine();
            Console.Write("");
            Console.Write("");
            Car c = new Car(modelno, yearmake, gear, capacityCC, seats, door, stearingSystem);
            string specification = "";
            while (specification.ToLower()!="ok")
            {
                Console.WriteLine("After Interior Desing press 'ok' for stop");
                Console.WriteLine("Add your Interior Design: ");
                specification=Console.ReadLine();
                if (specification.ToLower() != "ok")
                {
                    c.AddSpeciffication(specification);
                }

            }

            Console.WriteLine("------------------ Car Info ----------------------");
            Console.WriteLine("Model No: "+c.modelNo);
            Console.WriteLine("Year Make: "+c.yearMake);
            Console.WriteLine("Number of Seats: "+c.numberofSeats);
            Console.WriteLine("Engine Capacity CC: "+c.engineCapacityCC);
            Console.WriteLine("Stearing System: "+c.stearingSystem);
            Console.WriteLine("Interior Design: " + c.ShowSpecification<Car>(ref c));
        }
        public static void MotorCycleSystem()
        {
            Console.Write("MODEL NO: ");
            string model=Console.ReadLine();
            Console.Write("YEAR MAKE: ");
            int yearmake=int.Parse(Console.ReadLine());
            Console.Write("NUMBER OF GEAR: ");
            int numberofgear=int.Parse(Console.ReadLine());
            Console.Write("STARTING METHOD: ");
            string startingmethod=Console.ReadLine();
            Console.Write("ENGINE CAPACITY CC: ");
            int capacity=int.Parse(Console.ReadLine());
            Console.Write("MAXIMUM POWER BPH: ");
            int powerbph=int.Parse(Console.ReadLine());
            Console.Write("MAXIMUM TORQUE NM: ");
            int torque=int.Parse(Console.ReadLine());
            Console.Write("MILEAG KMPL: ");
            int mileagKMPL=int.Parse(Console.ReadLine());
            Console.Write("COOLING SYSTEM: ");
            string cooling=Console.ReadLine();
            Console.Write("FRONT BRAKE: ");
            string frontbrake = Console.ReadLine();
            Console.Write("REAR BRAKE: ");
            string rearBrake=Console.ReadLine();
            Console.Write("");
            
            MotorCycle m=new MotorCycle(model, yearmake, numberofgear, capacity,startingmethod,powerbph,torque, mileagKMPL,cooling,frontbrake,rearBrake);
            string specification = "";
            while (specification.ToLower()!="ok")
            {
                Console.WriteLine("Befor adding Exterior Design press 'ok' for stop.");
                Console.WriteLine("Enter your Exterior Design: ");
                specification=Console.ReadLine();
                if (specification.ToLower()!="ok")
                {
                    m.AddSpecification(specification);
                }
            }

            Console.WriteLine("------------------- MOTORCYCLE -----------------------");
            Console.WriteLine("Model No: "+m.modelNo);
            Console.WriteLine("Year Make: "+m.yearMake);
            Console.WriteLine("Starting Method: "+m.startngMethod);
            Console.WriteLine("Cooling System: "+m.cooling);
            Console.WriteLine("Front Brake System: "+m.frontBrake);
            Console.WriteLine("Exterior Design: "+m.ShowSpecification<MotorCycle>(ref m));
            Console.WriteLine("-------------------- Well Done -------------------------");
        }
    }
}
