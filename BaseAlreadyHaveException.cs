using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class BaseAlreadyHaveException : Exception
    {
        public BaseAlreadyHaveException() : base("На парковке уже есть такое транспортное средство") 
        { }
    }
}
