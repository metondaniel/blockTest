using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using BlockDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Service
{
    public class BlockHeaderService : ServiceBase<BlockHeader>, IBlockHeaderService
    {
        public IBlockHeaderRepository _repository;
        public BlockHeaderService(IBlockHeaderRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> AddUpdate(string name, BlockHeader block)
        {
            return _repository.AddUpdate(name, block);
        }
    }
}
