using BlockDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Interfaces.Repository
{
    public interface IBlockHeaderRepository : IRepositoryBase<BlockHeader>
    {
        Task<bool> AddUpdate( string name, BlockHeader entity );
    }
}
