﻿using System;
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
            //Order
            CreateMap<Order, OrderVM>();
            CreateMap<OrderItemVM, OrderDetail>();
            CreateMap<OrderDetail, OrderItemVM>();

            CreateMap<OrderDetailVM, Order>()
                .ForMember(des => des.OrderDetails, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<Order, OrderDetailVM>()
                .ForMember(des => des.OrderItems, opt => opt.MapFrom(src => src.OrderDetails));


        }
    }
}