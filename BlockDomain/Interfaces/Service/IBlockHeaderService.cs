using BlockDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Interfaces.Service
{
    public interface IBlockHeaderService : IServiceBase<BlockHeader>
    {
        Task<bool> AddUpdate(string name,  BlockHeader block);
    }
}
