using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BlockDomain.Domain;

namespace BlockDomain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<BlockBusiness> GetByName(string name);
        Task<IEnumerable<T>> GetAll();
        Task AddRange(string name, IEnumerable<BlockBusiness> entities );
    }
}
