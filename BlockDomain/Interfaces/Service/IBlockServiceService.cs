using BlockDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Interfaces.Service
{
    public interface IBlockServiceService : IServiceBase<BlockService>
    {
        Task<bool> AddUpdate(string name, BlockService block );
    }
}
