using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public interface IExteriorDesign
    {
        void AddSpecification(string specification);
        string ShowSpecification<T>(ref T data);
    }
}
