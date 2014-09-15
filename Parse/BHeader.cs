using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class BHeader
    {
        private static readonly int m_signature = 0x61754C1B;

        private static readonly byte[] m_luacTail = {
            0x19, 0x93, 0x0D, 0x0A, 0x1A, 0x0A
        };

        public bool Debug { get; set; }

        public Version Version { get; set; }

        public BIntegerType Integer { get; set; }
        public BSizeTType SizeT { get; set; }
        public LBooleanType Bool { get; set; }
        public LNumberType Number { get; set; }
        public LStringType String { get; set; }
        public LConstantType Constant { get; set; }
        public LLocalType Local { get; set; }
        public LUpvalueType UpValue { get; set; }
        public LFunctionType Function { get; set; }
    }
}
