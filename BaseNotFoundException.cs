using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class BaseNotFoundException : Exception
    {
        public BaseNotFoundException(int i) : base("Не найдена машина по месту " + i) 
        { }
    }
}
