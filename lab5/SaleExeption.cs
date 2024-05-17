using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class SaleException : Exception
    {
        public SaleException(string message) : base(message)
        {
        }
    }
}
