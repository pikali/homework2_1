using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2_1
{
    class EquationNode
    {
        private Num number;
        private EquationNode leftNode;
        private EquationNode rightNode;

        public EquationNode(EquationNode node1, EquationNode node2)
        {
            leftNode = node1;
            rightNode = node2;
        }
    }
}
