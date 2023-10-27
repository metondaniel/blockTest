using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using BlockDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Service
{
    public class BlockServiceService : ServiceBase<BlockService>, IBlockServiceService
    {
        public IBlockServiceRepository _repository;
        public BlockServiceService(IBlockServiceRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public Task<bool> AddUpdate(string name, BlockService block)
        {
            return _repository.AddUpdate(name, block);
        }
    }
}
