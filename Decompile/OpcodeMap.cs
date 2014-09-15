using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public class OpcodeMap
    {
        private Op[] m_map;

        public Op this[int opcode]
        {
            get { return GetOp(opcode); }
        }

        public Op GetOp(int opcode)
        {
            if (opcode >= 0 && opcode < m_map.Length)
            {
                return m_map[opcode];
            }
            else
            {
                throw new ArgumentOutOfRangeException("opcode", opcode,
                    "The specified opcode exceeds the boundaries of valid opcodes.");
            }
        }

        public OpcodeMap(int version)
        {
            if (version == 0x51)
            {
                m_map = new Op[38] {
                    Op.MOVE,
                    Op.LOADK,
                    Op.LOADBOOL,
                    Op.LOADNIL,
                    Op.GETUPVAL,
                    Op.GETGLOBAL,
                    Op.GETTABLE,
                    Op.SETGLOBAL,
                    Op.SETUPVAL,
                    Op.SETTABLE,
                    Op.NEWTABLE,
                    Op.SELF,
                    Op.ADD,
                    Op.SUB,
                    Op.MUL,
                    Op.DIV,
                    Op.MOD,
                    Op.POW,
                    Op.UNM,
                    Op.NOT,
                    Op.LEN,
                    Op.CONCAT,
                    Op.JMP,
                    Op.EQ,
                    Op.LT,
                    Op.LE,
                    Op.TEST,
                    Op.TESTSET,
                    Op.CALL,
                    Op.TAILCALL,
                    Op.RETURN,
                    Op.FORLOOP,
                    Op.FORPREP,
                    Op.TFORLOOP,
                    Op.SETLIST,
                    Op.CLOSE,
                    Op.CLOSURE,
                    Op.VARARG
                };
            }
            else
            {
                m_map = new Op[40] {
                    Op.MOVE,
                    Op.LOADK,
                    Op.LOADKX,
                    Op.LOADBOOL,
                    Op.LOADNIL,
                    Op.GETUPVAL,
                    Op.GETTABUP,
                    Op.GETTABLE,
                    Op.SETTABUP,
                    Op.SETUPVAL,
                    Op.SETTABLE,
                    Op.NEWTABLE,
                    Op.SELF,
                    Op.ADD,
                    Op.SUB,
                    Op.MUL,
                    Op.DIV,
                    Op.MOD,
                    Op.POW,
                    Op.UNM,
                    Op.NOT,
                    Op.LEN,
                    Op.CONCAT,
                    Op.JMP,
                    Op.EQ,
                    Op.LT,
                    Op.LE,
                    Op.TEST,
                    Op.TESTSET,
                    Op.CALL,
                    Op.TAILCALL,
                    Op.RETURN,
                    Op.FORLOOP,
                    Op.FORPREP,
                    Op.TFORCALL,
                    Op.TFORLOOP,
                    Op.SETLIST,
                    Op.CLOSURE,
                    Op.VARARG,
                    Op.EXTRAARG
                };
            }
        }
    }
}
