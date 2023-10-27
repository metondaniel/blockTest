using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using BlockDomain.Domain;

namespace BlockApplication.ViewModel
{
    public class BlockViewModelRequest
    {
        public BlockType Id { get; set; }
        public string Name { get; set; }
        public string JsonObject { get; set; }
    }
}
