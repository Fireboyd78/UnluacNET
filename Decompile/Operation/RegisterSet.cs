using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    // TODO: Finish 'RegisterSet' class
    public class RegisterSet : Operation
    {
        public int Register { get; private set; }
        public Expression Value { get; private set; }

        public override Statement Process(Registers r, Block block)
        {
            
        }
    }
}
