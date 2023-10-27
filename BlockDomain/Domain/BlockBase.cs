using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BlockDomain.Domain
{
    public class BlockBase
    {
        public BlockType Id { get; set; }
        public int BlockOrder { get; set; }
        public CtaButton CtaButton { get; set; }
    }
}
