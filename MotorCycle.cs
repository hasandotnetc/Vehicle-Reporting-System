using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public sealed class MotorCycle:TwoWheeler
    {
        public MotorCycle(string modelNo,int yearmake,int numberofgear,int capacityCC,string startingmethod,int BPH,int TorqueNM,int mileageKMPL,string cooling,string frontBrake,string rearBrake) 
        {
            this.modelNo = modelNo;
            this.yearMake = yearmake;
            this.numberofGear = numberofgear;
            this.engineCapacityCC = capacityCC;
            this.startngMethod = startingmethod;
            this.maximumPowerBPH = BPH;
            this.maximumTorqueNM = TorqueNM;
            this.mileageKMPL = mileageKMPL;
            this.cooling = cooling;
            this.frontBrake = frontBrake;
            this.rearBrake = rearBrake;
        }

        public string startngMethod { get; set; }
        public int maximumPowerBPH { get; set; }
        public int maximumTorqueNM { get; set; }
        public int mileageKMPL { get; set; }
        public string cooling { get; set; }
        public string frontBrake { get; set; }
        public string rearBrake { get; set; }
    }
}
