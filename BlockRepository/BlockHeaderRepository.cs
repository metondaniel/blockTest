using BlockDomain.Domain;
using BlockDomain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockRepository
{
    public class BlockHeaderRepository : RepositoryBase<BlockHeader>, IBlockHeaderRepository
    {
        public BlockHeaderRepository()
        {
        }

        public async Task<bool> AddUpdate( string name, BlockHeader entity )
        {
            try
            {
                string jsonBusiness = File.ReadAllText( "MyBusiness", Encoding.UTF8 );
                if( string.IsNullOrEmpty( jsonBusiness ) )
                {
                    var jsonObject = JsonConvert.DeserializeObject<List<BlockBusiness>>( jsonBusiness );
                    jsonObject.FirstOrDefault( x => x.Name == name ).Header = entity;
                    File.WriteAllText( "MyBusiness", JsonConvert.SerializeObject( jsonObject ) );
                }
                return true;
            }
            catch ( Exception ex )
            {
                return false;
            }
        }
    }
}
