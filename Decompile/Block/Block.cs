using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class Block : Statement, IComparable<Block>
    {
        protected readonly LFunction m_function;

        public int Begin { get; set; }
        public int End { get; set; }

        public bool LoopRedirectAdjustment { get; set; }

        public virtual int ScopeEnd
        {
            get { return End - 1; }
        }

        public abstract bool Breakable { get; }
        public abstract bool IsContainer { get; }
        public abstract bool IsUnprotected { get; }
        
        public abstract void AddStatement(Statement statement);
        public abstract int GetLoopback();

        public int CompareTo(Block block)
        {
            if (Begin < block.Begin)
            {
                return -1;
            }
            else if (Begin == block.Begin)
            {
                if (End < block.End)
                {
                    return 1;
                }
                else if (End == block.End)
                {
                    if (IsContainer && !block.IsContainer)
                    {
                        return -1;
                    }
                    else if (!IsContainer && block.IsContainer)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 1;
            }
        }

        public bool Contains(Block block)
        {
            return (Begin <= block.Begin) && (End >= block.End);
        }

        public bool Contains(int line)
        {
            return (Begin <= line) && (line < End);
        }

        public Operation Process(Decompiler d)
        {
            return new GenericOperation(ScopeEnd, this);
        }

        public Block(LFunction function, int begin, int end)
        {
            m_function = function;
            
            Begin = begin;
            End = end;
        }
    }
}
