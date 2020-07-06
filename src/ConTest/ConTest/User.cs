using System;
using System.Collections.Generic;
using System.Text;

namespace ConTest
{
    public class User
    {
        public string Name { get; set; }
        public string Sex { get; set; }

        public override string ToString()
        {
            return $@"{Name} {Sex}";
        }
    }
}
