using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class VariableTarget : Target
    {
        public Declaration Decl { get; private set; }

        public override bool IsLocal
        {
            get { return true; }
        }

        public override bool IsDeclaration(Declaration decl)
        {
            return Decl == decl;
        }

        public override bool Equals(object obj)
        {
            if (obj is VariableTarget)
                return Decl == ((VariableTarget)obj).Decl;
            else
                return false;
        }

        public override int GetIndex()
        {
            return Decl.Register;
        }

        public override void Print(Output output)
        {
            output.Print(Decl.Name);
        }

        public override void PrintMethod(Output output)
        {
            throw new InvalidOperationException();
        }
    }
}
