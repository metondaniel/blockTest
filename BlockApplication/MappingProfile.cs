using AutoMapper;
using BlockApplication.ViewModel;
using BlockDomain.Domain;
using System;

namespace BlockApplication
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BlockViewModelRequest, BlockBase>();
            CreateMap<BlockBase, BlockViewModelRequest>();
        }
    }
}
