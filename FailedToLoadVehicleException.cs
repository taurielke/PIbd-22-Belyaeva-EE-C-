using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class FailedToLoadVehicleException : Exception
    {
        public FailedToLoadVehicleException() : base("Не удалось загрузить машину на парковку")
        { }
    }
}
