using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            CreateMap<Fee, FeeVM>();
            //Type Product
            CreateMap<TypeProductVM, TypeProduct>();
            CreateMap<TypeProduct, TypeProductVM>();
            //Product
            CreateMap<ProductAttr, ProductAttributeVM>();
            CreateMap<ProductAttributeVM, ProductAttr>();
            CreateMap<ProductAttr, OrderItemVM>()
                .ForMember(item => item.AttributeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(item => item.ProductId, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(item => item.Name, opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(item => item.Price, opt => opt.MapFrom(src => src.Product.Price))
                .ForMember(item => item.Image, opt => opt.MapFrom(src => src.Product.Image));

            //
            CreateMap<ProductVM, Product>();

            CreateMap<Product, ProductVM>()
                .ForMember(des => des.Rate, opt => opt.MapFrom(src => _calAverageRate(src.Ratings)));

            //
            CreateMap<ProductDetailVM, Product>()
                .ForMember(des => des.ProductAttrs, opt => opt.MapFrom(src => src.ProductAttributes));
            CreateMap<Product, ProductDetailVM>()
                .ForMember(des => des.ProductAttributes, opt => opt.MapFrom(src => src.ProductAttrs))
                .ForMember(des => des.Rate, opt => opt.MapFrom(src => _calAverageRate(src.Ratings)));

            //Order
            CreateMap<Order, OrderVM>();

            CreateMap<OrderDetailVM, Order>()
                .ForMember(des => des.OrderDetails, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<Order, OrderDetailVM>()
                .ForMember(des => des.OrderItems, opt => opt.MapFrom(src => src.OrderDetails));

            CreateMap<OrderDetail, OrderItemVM>()
                .ForMember(des => des.AttributeId, opt => opt.MapFrom(src => src.ProductAttrId))
                .ForMember(des => des.ProductId, opt => opt.MapFrom(src => src.ProductAttr.ProductId))
                .ForMember(des => des.Name, opt => opt.MapFrom(src => src.ProductAttr.Product.Name))
                .ForMember(des => des.Image, opt => opt.MapFrom(src => src.ProductAttr.Product.Image))
                .ForMember(des => des.Size, opt => opt.MapFrom(src => src.ProductAttr.Size));

            CreateMap<OrderItemVM, OrderDetail>()
                .ForMember(des => des.ProductAttrId, opt => opt.MapFrom(src => src.AttributeId));
            //Rating
            CreateMap<Rating, RatingVM>()
                .ForMember(des => des.CustomerName, otp => otp.MapFrom(src => src.User.CustomerName));
            CreateMap<RatingVM, Rating>();
            //User
            CreateMap<User, UserVM>()
                .ForMember(des => des.Phone, opt => opt.MapFrom(src => src.PhoneNumber));

        }

        private double _calAverageRate(ICollection<Rating> ratings)
        {
            if (ratings == null || ratings.Count == 0) return 0;
            var avg = ratings.Select(item => item.Rate).Average();
            return Math.Ceiling(avg);

        }
    }
}
