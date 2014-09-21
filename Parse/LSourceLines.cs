using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class LSourceLines
    {
        public static LSourceLines Parse(Stream stream)
        {
            var number = stream.ReadInt32();

            //while (number-- > 0)
            //    stream.ReadInt32();

            if (number > 0)
                stream.Position += (number * sizeof(int));

            return null;
        }
    }
}
