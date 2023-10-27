using System;
using System.Collections.Generic;
using System.Text;

namespace BlockDomain.Domain
{
    public class ServiceCard
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public CtaButton CtaButton { get; set; }
    }
}
