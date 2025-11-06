using AutoMapper;
using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.DAL.Entities.Products;

namespace Electro.Shop.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Name));

            //CreateMap<ProductCreateDto, Product>();
            //CreateMap<ProductUpdateDto, Product>();
        }
    }
}
