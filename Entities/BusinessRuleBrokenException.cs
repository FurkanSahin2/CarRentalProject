using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class BusinessRuleBrokenException : Exception
    {
        public BusinessRuleBrokenException(string message) : base(message)
        {

        }
    }
}
