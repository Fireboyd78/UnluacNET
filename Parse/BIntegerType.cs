using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    // TODO: Finish 'BIntegerType' class
    public class BIntegerType : BObjectType<BInteger>
    {
        public override BInteger Parse(System.IO.Stream stream, BHeader header)
        {
            return null;
        }
    }
}
