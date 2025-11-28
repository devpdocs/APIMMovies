using AutoMapper;
using API.M.Movies.DAL.Models;
using API.M.Movies.DAL.Models.Dtos;

namespace API.M.Movies.MoviesMapper
{
    public class Mappers : Profile 
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDtos>().ReverseMap();
            CreateMap<Category, CategoryCreateDtos>().ReverseMap();
        }

    }
}
