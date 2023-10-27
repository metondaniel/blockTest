using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlockRepository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public RepositoryBase()
        {
        }
        
        public async Task AddRange(string name, IEnumerable<BlockBusiness> entities)
        {   
            File.WriteAllText( "MyBusiness", JsonConvert.SerializeObject( entities ) );
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return JsonConvert.DeserializeObject<IEnumerable<T>>(File.ReadAllText( "MyBusiness", Encoding.UTF8));
        }
        public virtual async Task<BlockBusiness> GetByName(string name)
        {
            return JsonConvert.DeserializeObject<IEnumerable<BlockBusiness>>( File.ReadAllText( "MyBusiness", Encoding.UTF8 ) ).FirstOrDefault(x => x.Name == name);
        }
    }
}
