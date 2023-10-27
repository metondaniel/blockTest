using System;
using System.Collections.Generic;
using System.Text;

namespace BlockDomain.Domain
{
    public class BlockHeader : BlockBase
    {
        public string BusinessName { get; set; }
        public string Password { get; set; }
        public Dictionary<string, bool> Logo { get; set; }
        public List<Menu> Menu { get; set; }
    }
}
