using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;
using AutoMapper;
    

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile // AutoMapper için Profile'dan kalıtım aldık.
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<RoomUpdateDto, Room>().ReverseMap(); // iki satır yazmaya gerek kalmadı

        }
    }
}
