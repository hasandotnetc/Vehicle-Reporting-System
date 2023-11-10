using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_generic
{
    public  interface IInteriorDesign
    {
        void AddSpeciffication(string speciffication);
        string ShowSpecification<T>(ref T data) where T : class;
    }
}
