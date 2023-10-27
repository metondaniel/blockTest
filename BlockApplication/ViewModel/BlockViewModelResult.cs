using System;
using System.Collections.Generic;
using System.Text;
using BlockDomain.Domain;

namespace BlockApplication.ViewModel
{
    public class BlockViewModelResult
    {
        public BlockHeader Header { get; set; }
        public BlockHero BlockHero { get; set; }
        public BlockService BlockService { get; set; }
    }
}
