using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class LString : LObject
    {
        public BSizeT Size { get; private set; }
        public string Value { get; private set; }

        public override bool Equals(object obj)
        {
            var o = obj as LString;

            if (o != null)
                return o.Value == Value;

            return false;
        }

        public override string DeRef()
        {
            return Value;
        }

        public override string ToString()
        {
            return String.Format("\"{0}\"", Value);
        }
    }
}
