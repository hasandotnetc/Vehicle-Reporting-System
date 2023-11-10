using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public abstract class FourWheeler : Vehicle, IInteriorDesign
    {
        List<string>Specification=new List<string>();
        public void AddSpeciffication(string speciffication)
        {
            Specification.Add(speciffication);
        }

        public string ShowSpecification<T>(ref T data) where T : class
        {
            if (data is Car)
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
