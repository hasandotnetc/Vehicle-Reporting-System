using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public sealed class Car:FourWheeler
    {
        public Car(string modelNo, int yearmake, int numberofgear, int capacityCC,int seats,int door,string stearingsystem) 
        
        
        { 
            this.modelNo = modelNo;
            this.yearMake = yearmake;
            this.numberofGear = numberofgear;
            this.engineCapacityCC = capacityCC;
            this.numberofSeats = seats;
            this.numberofDoor = door;
            this.stearingSystem = stearingsystem;
        }
        public int numberofSeats { get; set; }
        public int numberofDoor { get; set; }
        public string stearingSystem { get; set; }
    }
}
