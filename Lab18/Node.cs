using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    class Node
    {
        public int Data
        {
            set; get;
        }

        public Node Next { set; get; }
        public Node Previous { set; get; }

    }
}
