using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Login.Exceptions
{
    class HotelException : ApplicationException
    {
        public HotelException(string message)
            : base(message)
        {
        }
    }
}
