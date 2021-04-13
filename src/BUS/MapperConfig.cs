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
            CreateMap<ProductDetail, ProductAttributeVM>();
            CreateMap<ProductAttributeVM, ProductDetail>();
            CreateMap<ProductDetail, CartItemVM>()
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
                .ForMember(des => des.ProductDetails, opt => opt.MapFrom(src => src.ProductAttributes));
            CreateMap<Product, ProductDetailVM>()
                .ForMember(des => des.ProductAttributes, opt => opt.MapFrom(src => src.ProductDetails))
                .ForMember(des => des.Rate, opt => opt.MapFrom(src => _calAverageRate(src.Ratings)));

            //Order
            CreateMap<Order, OrderVM>();
            CreateMap<OrderItemVM, OrderDetail>();
            CreateMap<OrderDetail, OrderItemVM>();

            CreateMap<OrderDetailVM, Order>()
                .ForMember(des => des.OrderDetails, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<Order, OrderDetailVM>()
                .ForMember(des => des.OrderItems, opt => opt.MapFrom(src => src.OrderDetails));

            //Rating
            CreateMap<Rating, RatingVM>()
                .ForMember(des => des.CustomerName, otp => otp.MapFrom(src => src.User.CustomerName));
            CreateMap<RatingVM, Rating>();

        }

        private double _calAverageRate(ICollection<Rating> ratings)
        {
            if (ratings == null || ratings.Count == 0) return 0;
            var avg = ratings.Select(item => item.Rate).Average();
            return Math.Ceiling(avg);

        }
    }
}
