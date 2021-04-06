using System;
using AutoMapper;
using BUS.Domains;
using Shared.ViewModels;

namespace BUS
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            //Category
            CreateMap<CategoryVM, Category>();
            CreateMap<Category, CategoryVM>();
            //Fee
            CreateMap<FeeVM, Fee>();
            CreateMap<Fee, Fee>();
            //Type Product
            CreateMap<TypeProductVM, TypeProduct>();
            CreateMap<TypeProduct, TypeProductVM>();
            //Product
            CreateMap<ProductVM, Product>();
            CreateMap<Product, ProductVM>();
        }
    }
}
