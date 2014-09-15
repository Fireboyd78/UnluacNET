using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnluacNET
{
    // TODO: Finish 'Assignment' class
    public class Assignment : Statement
    {
        private readonly List<Target> m_targets     = new List<Target>(5);
        private readonly List<Expression> m_values  = new List<Expression>(5);

        private bool m_allNil       = true;
        private bool m_declare      = false;
        private int m_declareStart  = 0;

        public int GetArity()
        {
            return m_targets.Count;
        }

        public Target GetFirstTarget()
        {
            return m_targets[0];
        }

        public Expression GetFirstValue()
        {
            return m_values[0];
        }

        public bool AssignsTarget(Declaration decl)
        {
            foreach (var target in m_targets)
                if (target.IsDeclaration(decl))
                    return true;

            return false;
        }

        public Assignment() { }

        public Assignment(Target target, Expression value)
        {
            m_targets.Add(target);
            m_values.Add(value);

            m_allNil = m_allNil && value.IsNil;
        }
    }
}
