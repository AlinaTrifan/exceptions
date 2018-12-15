using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class DressCodeException :ApplicationException
    {
        private readonly string message = "you are not wearing an elf costume and you are under age";
        public DressCodeException()
        {
            Console.WriteLine(message);
        }
    }
}
