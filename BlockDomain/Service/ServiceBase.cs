using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using BlockDomain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlockDomain.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public IRepositoryBase<T> _repository;
        public ServiceBase(IRepositoryBase<T> repository)
        { 
            _repository = repository;
        }

        public async Task AddRange(string name, IEnumerable<BlockBusiness> entities )
        {
            await _repository.AddRange(name,entities);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<BlockBusiness> GetByName(string name)
        {
            return await _repository.GetByName(name);
        }
    }
}
