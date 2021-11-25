using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class BaseOccupiedPlaceException : Exception
    {
        public BaseOccupiedPlaceException() : base("Это место занято")
        { }
    }
}
