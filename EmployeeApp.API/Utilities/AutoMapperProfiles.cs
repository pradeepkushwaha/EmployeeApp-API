using AutoMapper;
using EmployeeApp.API.Entities;
using EmployeeApp.API.Models;
using EmployeeApp.API.Utilities;

namespace EmployeeApp.API.Utilites
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //CreateMap<Employee, EmployeeForDetailedEntity>();
            //CreateMap<Employee, EmployeeForListEntity>();
            CreateMap<Employee, EmployeeForDetailedEntity>()
                .ForMember(
                    destination => destination.Full_name,
                    options => options.MapFrom(source => source.First_name + " " + source.Last_name)
                )
                .ForMember(dest => dest.Age, opt =>
                {
                    opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<Employee, EmployeeForListEntity>()
                .ForMember(
                    destination => destination.Full_name,
                    options => options.MapFrom(source => source.First_name + " " + source.Last_name)
                 )
                 .ForMember(dest => dest.Age, opt =>
                 {
                     opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                 });


        }
    }
}
