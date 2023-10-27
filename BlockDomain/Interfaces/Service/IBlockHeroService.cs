using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Interfaces.Service
{
    public interface IBlockHeroService : IServiceBase<BlockHero>
    {
        Task<bool> AddUpdate(string name, BlockHero block); 
    }
}
