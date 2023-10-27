using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockRepository
{
    public class BlockServiceRepository : RepositoryBase<BlockService>, IBlockServiceRepository
    {
        public BlockServiceRepository()
        {
        }

        public async Task<bool> AddUpdate( string name, BlockService entity )
        {
            try
            {
                string jsonBusiness = File.ReadAllText( "MyBusiness", Encoding.UTF8 );
                if( string.IsNullOrEmpty( jsonBusiness ) )
                {
                    var jsonObject = JsonConvert.DeserializeObject<List<BlockBusiness>>( jsonBusiness );
                    jsonObject.FirstOrDefault( x => x.Name == name ).BlockService = entity;
                    File.WriteAllText( "MyBusiness", JsonConvert.SerializeObject( jsonObject ) );
                }
                return true;
            }
            catch ( Exception ex ) { 
            return false;
            }
        }
    }
}
