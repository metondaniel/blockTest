using AutoMapper;
using BlockApplication.ViewModel;
using BlockDomain.Domain;
using BlockDomain.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Block.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlockController : ControllerBase
    {
        private IBlockHeroService _blockHeroService;
        private IBlockHeaderService _blockHeaderService;
        private IBlockServiceService _blockServiceService;
        private IMapper _mapper;

        public BlockController(IBlockHeaderService blockHeaderService, IBlockHeroService blockHeroService, IBlockServiceService blockServiceService, IMapper mapper)
        {
            _blockHeroService = blockHeroService;
            _blockHeaderService = blockHeaderService;
            _blockServiceService = blockServiceService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<bool>> Create(BlockViewModelRequest blockViewModel)
        {
            try
            {
                switch( blockViewModel.Id )
                {
                    case BlockType.Header:
                        return await _blockHeaderService.AddUpdate( blockViewModel.Name,JsonConvert.DeserializeObject<BlockHeader>( blockViewModel.JsonObject ) );

                    case BlockType.Hero:
                        return await _blockHeroService.AddUpdate( blockViewModel.Name, JsonConvert.DeserializeObject<BlockHero>( blockViewModel.JsonObject ) );

                    case BlockType.Service:
                        return await _blockServiceService.AddUpdate( blockViewModel.Name, JsonConvert.DeserializeObject<BlockService>( blockViewModel.JsonObject ) );
                    default:
                        List<BlockBusiness> businessList = new List<BlockBusiness>();
                        foreach(var item in JsonConvert.DeserializeObject<IEnumerable<BlockBusiness>>( blockViewModel.JsonObject ) )
                        {
                            item.Name = blockViewModel.Name;
                            businessList.Add( item );
                        }
                        await _blockServiceService.AddRange( blockViewModel.Name, businessList );
                        break;
                }
                return Ok(true);
            }catch(Exception ex)
            {
                return BadRequest(false);
            }
            
        }

        [HttpPut]
        public async Task<ActionResult<bool>> Update(int id,BlockViewModelRequest blockViewModel)
        {
            try
            {
                switch( blockViewModel.Id )
                {
                    case BlockType.Header:
                        return await _blockHeaderService.AddUpdate( blockViewModel.Name, JsonConvert.DeserializeObject<BlockHeader>( blockViewModel.JsonObject ) );

                    case BlockType.Hero:
                        return await _blockHeroService.AddUpdate( blockViewModel.Name, JsonConvert.DeserializeObject<BlockHero>( blockViewModel.JsonObject ) );

                    case BlockType.Service:
                        return await _blockServiceService.AddUpdate( blockViewModel.Name, JsonConvert.DeserializeObject<BlockService>( blockViewModel.JsonObject ) );

                }
                return false;
            }
            catch( Exception ex )
            {
                return BadRequest( false );
            }

        }

        [HttpGet("name")]
        public async Task<ActionResult<bool>> Get(string name)
        {
            try
            {
                var block = await _blockHeroService.GetByName(name);
                return Ok(JsonConvert.SerializeObject(block));
            }
            catch (Exception ex)
            {
                return BadRequest(false);
            }

        }

        [HttpGet( )]
        public async Task<ActionResult<bool>> GetAll( )
        {
            try
            {
                var block = await _blockHeroService.GetAll();
                return Ok( JsonConvert.SerializeObject( block ) );
            }
            catch( Exception ex )
            {
                return BadRequest( false );
            }

        }
    }
}
