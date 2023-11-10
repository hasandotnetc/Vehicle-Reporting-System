using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public abstract class TwoWheeler : Vehicle, IExteriorDesign
    {
        List<string>Specification=new List<string>();
        public void AddSpecification(string specification)
        {
            Specification .Add(specification);
        }

        public string ShowSpecification<T>(ref T data)
        {
            if (data is MotorCycle)
            {
                return string.Join(", ", Specification);
            }
            else
            {
                return string.Empty; 
            }
        }
    }
}
