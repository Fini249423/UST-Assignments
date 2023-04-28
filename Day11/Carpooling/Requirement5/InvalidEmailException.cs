using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requirement5
{

    class InvalidEmailException : Exception

    {

        public InvalidEmailException(string message) : base(message)

        {

        }

    }
}

