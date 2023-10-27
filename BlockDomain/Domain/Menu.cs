using System;
using System.Collections.Generic;
using System.Text;

namespace BlockDomain.Domain
{
    public class Menu
    {
        public KeyValuePair<string,string> LinkName { get; set; }
        public List<KeyValuePair<string, string>> SubMenu { get; set; }
    }
}
