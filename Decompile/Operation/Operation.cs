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

    public class GenericOperation : Operation
    {
        private readonly Statement m_statement;

        public override Statement Process(Registers r, Block block)
        {
            return m_statement;
        }

        public GenericOperation(int line, Statement statement)
            : base(line)
        {
            m_statement = statement;
        }
    }
}
