using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelyaevaTank
{
    public class WrongFormatException : Exception
    {
        public WrongFormatException() : base ("Неверный формат файла")
        { }
    }
}
