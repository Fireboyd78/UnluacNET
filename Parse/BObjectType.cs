using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    // TODO: Finish 'BObjectType<T>' class
    public abstract class BObjectType<T> : BObject
        where T : BObject
    {
        public abstract T Parse(Stream stream, BHeader header);

        public BList<T> ParseList(Stream strean, BHeader headeR)
        {
            return null;
        }
    }
}
