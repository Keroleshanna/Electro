using AutoMapper;
using Electro.Shop.BLL.DTOs.Products;
using Electro.Shop.DAL.Entities.Products;

namespace Electro.Shop.BLL.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductReadDto>()
                .ForMember(PR => PR.MainImage, p => p.MapFrom(src =>
                    src.ProductImages
                        .Where(i => i.IsMain)
                        .Select(i => i.ImageUrl)
                        .FirstOrDefault()
                ));


            CreateMap<Product, ProductDetailsDto>()
                .ForMember(p => p.Images, p => p.MapFrom(src =>
                src.ProductImages.Select(img => img.ImageUrl).ToList()));
        }
    }
}
