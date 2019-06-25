using System;
using System.Collections.Generic;
using System.Text;

namespace Stopwatch2
{
    public class Stopwatch
    {
        private DateTime _start;

        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }
    }
}
