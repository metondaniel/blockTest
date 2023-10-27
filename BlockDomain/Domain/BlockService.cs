using System;
using System.Collections.Generic;
using System.Text;

namespace BlockDomain.Domain
{
    public class BlockService : BlockBase
    {
        public string HeadlineText { get; set; }
        public ServiceCard Card { get; set; }
    }
}
