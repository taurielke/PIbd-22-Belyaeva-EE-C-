using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class BaseOverflowException : Exception
    {
        public BaseOverflowException() : base("На парковке нет свободных мест") 
        { }
    }
}
