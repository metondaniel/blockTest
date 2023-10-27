using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace BlockDomain.Domain
{
    public class BlockHero : BlockBase
    {
        public string HeadlineText { get; set; }
        public string DescriptionText { get; set;}
        public string HeroImageLink { get; set; }
        public string ImageAlign { get; set; }
        public string ContentAlign { get; set; }
        public CtaButton CtaButton { get; set; }
    }
}
