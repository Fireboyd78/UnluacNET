using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class Code
    {
        private readonly OpcodeMap map;
        private readonly int[] code;

        public static int Extract_A(int codePoint)
        {
            return (codePoint >> 6) & 0x0000000FF;
        }

        public static int Extract_C(int codePoint)
        {
            return (codePoint >> 14) & 0x000001FF;
        }

        public static int Extract_B(int codePoint)
        {
            return (ushort)(codePoint >> 23);
        }

        public static int Extract_Bx(int codePoint)
        {
            return (ushort)(codePoint >> 14);
        }

        public static int Extract_sBx(int codePoint)
        {
            return (ushort)((codePoint >> 14) - 131071);
        }

        public Op Op(int line)
        {
            return map.GetOp(code[line - 1] & 0x0000003F);
        }

        public int A(int line)
        {
            return Extract_A(code[line - 1]);
        }

        public int C(int line)
        {
            return Extract_C(code[line - 1]);
        }

        public int B(int line)
        {
            return Extract_B(code[line - 1]);
        }

        public int Bx(int line)
        {
            return Extract_Bx(code[line - 1]);
        }

        public int sBx(int line)
        {
            return Extract_sBx(code[line - 1]);
        }

        public int CodePoint(int line)
        {
            return code[line - 1];
        }

        public Code(LFunction function)
        {
            code = function.Code;
            map = function.Header.Version.GetOpcodeMap();
        }   
    }
}
