﻿using AutoMapper;
using HotelWebsite.DtoLayer.Dtos.RoomDto;
using HotelWebsite.EntityLayer.Concrete;

namespace HotelWebsite.WebApi.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();

            CreateMap<UpdateRoomDto, Room>().ReverseMap();
        }
    }
}
