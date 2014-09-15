using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public abstract class Operation
    {
        public int Line { get; private set; }

        public abstract Statement Process(Registers r, Block block);

        public Operation(int line)
        {
            Line = line;
        }
    }
}
