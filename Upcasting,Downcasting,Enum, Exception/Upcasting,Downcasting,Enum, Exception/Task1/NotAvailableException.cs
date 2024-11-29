using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upcasting_Downcasting_Enum__Exception.Task1
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException() : base("")
        {

        }

        public NotAvailableException( string? massage) : base(massage) 
        {
           
        }

    }
}
