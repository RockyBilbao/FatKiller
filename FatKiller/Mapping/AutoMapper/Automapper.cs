using AutoMapper;
using FatKiller.Data.Model;
using FatKiller.ViewModel;

namespace FatKiller.Mapping.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
        }
    }
}
