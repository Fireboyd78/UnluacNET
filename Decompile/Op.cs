using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    public sealed class Opcode
    {
        // TODO: Optimize method
        public static string CodePointToString(Op opcode, int codepoint)
        {
            var name = opcode.GetType().Name;

            switch (opcode)
            {
            // A
            case Op.CLOSE:
            case Op.LOADKX:
                    return String.Format("{0} {1}",
                        name, Code.Extract_A(codepoint));

            // A_B
            case Op.MOVE:
            case Op.LOADNIL:
            case Op.GETUPVAL:
            case Op.SETUPVAL:
            case Op.UNM:
            case Op.NOT:
            case Op.LEN:
            case Op.RETURN:
            case Op.VARARG:
                    return String.Format("{0} {1} {2}",
                        name, Code.Extract_A(codepoint), Code.Extract_B(codepoint));

            // A_C
            case Op.TEST:
            case Op.TFORLOOP:
            case Op.TFORCALL:
                    return String.Format("{0} {1} {2}",
                        name, Code.Extract_A(codepoint), Code.Extract_C(codepoint));
            
            // A_B_C
            case Op.LOADBOOL:
            case Op.GETTABLE:
            case Op.SETTABLE:
            case Op.NEWTABLE:
            case Op.SELF:
            case Op.ADD:
            case Op.SUB:
            case Op.MUL:
            case Op.DIV:
            case Op.MOD:
            case Op.POW:
            case Op.CONCAT:
            case Op.EQ:
            case Op.LT:
            case Op.LE:
            case Op.TESTSET:
            case Op.CALL:
            case Op.TAILCALL:
            case Op.SETLIST:
            case Op.GETTABUP:
            case Op.SETTABUP:
                    return String.Format("{0} {1} {2} {3}",
                        name,
                        Code.Extract_A(codepoint),
                        Code.Extract_B(codepoint),
                        Code.Extract_C(codepoint));

            // A_Bx
            case Op.LOADK:
            case Op.GETGLOBAL:
            case Op.SETGLOBAL:
            case Op.CLOSURE:
                    return String.Format("{0} {1} {2}",
                        name, Code.Extract_A(codepoint), Code.Extract_Bx(codepoint));

            // A_sBx
            case Op.FORLOOP:
            case Op.FORPREP:
                    return String.Format("{0} {1} {2}",
                        name, Code.Extract_A(codepoint), Code.Extract_sBx(codepoint));

            // Ax
            case Op.EXTRAARG:
                return String.Format("{0} <Ax>", name);

            // sBx
            case Op.JMP:
                return String.Format("{0} {1}",
                    name, Code.Extract_sBx(codepoint));

            default:
                return name;
            }
        }
    }

    public enum Op
    {
        // Lua 5.1 Opcodes
        MOVE,
        LOADK,
        LOADBOOL,
        LOADNIL,
        GETUPVAL,
        GETGLOBAL,
        GETTABLE,
        SETGLOBAL,
        SETUPVAL,
        SETTABLE,
        NEWTABLE,
        SELF,
        ADD,
        SUB,
        MUL,
        DIV,
        MOD,
        POW,
        UNM,
        NOT,
        LEN,
        CONCAT,
        JMP, // Different in 5.2
        EQ,
        LT,
        LE,
        TEST,
        TESTSET,
        CALL,
        TAILCALL,
        RETURN,
        FORLOOP,
        FORPREP,
        TFORLOOP,
        SETLIST,
        CLOSE,
        CLOSURE,
        VARARG,
        // Lua 5.2 Opcodes
        LOADKX,
        GETTABUP,
        SETTABUP,
        TFORCALL,
        EXTRAARG
    }
}
