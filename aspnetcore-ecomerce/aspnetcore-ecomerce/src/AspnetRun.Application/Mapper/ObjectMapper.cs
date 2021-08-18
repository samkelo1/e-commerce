﻿using AspnetRun.Application.Models;
using AspnetRun.Core.Entities;
using AutoMapper;
using System;

namespace AspnetRun.Application.Mapper
{
    public class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                // This line ensures that internal properties are also mapped over.
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<AspnetRunDtoMapper>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });
        public static IMapper Mapper => Lazy.Value;
        
        public class AspnetRunDtoMapper : Profile
        {
            public AspnetRunDtoMapper()
            {
                CreateMap<Product, ProductModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();

                CreateMap<Category, CategoryModel>().ReverseMap();
                CreateMap<Wishlist, WishlistModel>().ReverseMap();
                CreateMap<Compare, CompareModel>().ReverseMap();
                CreateMap<Order, OrderModel>().ReverseMap();
                CreateMap<Cart, CartModel>().ReverseMap();
                CreateMap<CartItem, CartItemModel>().ReverseMap();
            }
        }
    }
}
