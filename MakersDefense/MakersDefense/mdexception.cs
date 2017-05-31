using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersDefense
{
    class mdexception : Exception
    {
        public mdexception()
        {
        }

        public mdexception(string message) : base(message)
    {

        }
    }

    class OutOfBoundsException : mdexception
    {
        public OutOfBoundsException()
        {
        }

        public OutOfBoundsException(string message) : base(message)
        {
        }
    }
}

