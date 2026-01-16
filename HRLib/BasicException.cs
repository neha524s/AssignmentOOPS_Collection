using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
    public class BasicException:Exception
    {
        public BasicException(string msg) : base(msg)
        {
        }
    }
}
