using AutoMapper;
using CarCenter.Domain.Entities;
using System;
using static CarCenter.Common.Enums.MechanicEnum;

namespace CarCenter.Common.Mappers
{
    public class MechanicMapper : Profile
    {
        public MechanicMapper()
        {
            CreateMap<Mechanic, Infrastructure.Persistence.Entities.Mechanic>()
                .ForMember(dest => dest.celular, opt => opt.MapFrom(src => src.TelePhone))
                .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.direccion, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.documento, opt => opt.MapFrom(src => int.Parse(src.DocumentNumber)))
                .ForMember(dest => dest.tipo_documento, opt => opt.MapFrom(src => src.DocumentType))
                .ForMember(dest => dest.primer_nombre, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.segundo_nombre, opt => opt.MapFrom(src => src.SecondName))
                .ForMember(dest => dest.primer_apellido, opt => opt.MapFrom(src => src.Surname))
                .ForMember(dest => dest.segundo_apellido, opt => opt.MapFrom(src => src.SecondSurname));

            CreateMap<Infrastructure.Persistence.Entities.Mechanic, Mechanic>()
                .ForMember(dest => dest.TelePhone, opt => opt.MapFrom(src => src.celular))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.email))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.direccion))
                .ForMember(dest => dest.DocumentNumber, opt => opt.MapFrom(src => src.documento.ToString()))
                .ForMember(dest => dest.DocumentType, opt => opt.MapFrom(src => src.tipo_documento))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.primer_nombre))
                .ForMember(dest => dest.SecondName, opt => opt.MapFrom(src => src.segundo_nombre))
                .ForMember(dest => dest.Surname, opt => opt.MapFrom(src => src.primer_apellido))
                .ForMember(dest => dest.SecondSurname, opt => opt.MapFrom(src => src.segundo_apellido))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => (MechanicStatus) int.Parse(src.estado.ToString())));

        }
    }
}
