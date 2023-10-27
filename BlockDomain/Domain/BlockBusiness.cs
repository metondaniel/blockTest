using System;
using System.Collections.Generic;
using System.Text;

namespace BlockDomain.Domain
{
    public class BlockBusiness
    {
        public string Name { get; set; }
        public BlockHeader Header { get; set; }
        public BlockHero Hero { get; set; }
        public BlockService BlockService { get; set; }
    }
}
