using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using BlockDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Service
{
    public class BlockHeroService : ServiceBase<BlockHero>, IBlockHeroService
    {
        public IBlockHeroRepository _repository;
        public BlockHeroService(IBlockHeroRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> AddUpdate(string name, BlockHero block)
        {
            return _repository.AddUpdate(name,block);
        }

    }
}
