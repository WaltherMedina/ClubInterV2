using AutoMapper;
using ClubInterV2.DTO;
using ClubInterV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            #region Rol
            CreateMap<Trol,RolDTO>().ReverseMap();
            #endregion Rol

            #region Usuario
            CreateMap<Tusuario, UsuarioDTO>()
                .ForMember(destino =>
                    destino.RoleDescription,
                    opt => opt.MapFrom(origen => origen.Role.Roledescripcion))
                .ForMember(destino =>
                    destino.Userestado,
                    opt => opt.MapFrom(origen => origen.Userestado == true ? 1 : 0));
            CreateMap<Tusuario, SesionDTO>()
                .ForMember(destino =>
                    destino.RoleDescription,
                    opt => opt.MapFrom(origen => origen.Role.Roledescripcion));
            CreateMap<UsuarioDTO, Tusuario>()
                .ForMember(destino =>
                    destino.Role,
                    opt => opt.Ignore())
                .ForMember(destino =>
                    destino.Userestado,
                    opt => opt.MapFrom(origen => origen.Userestado == true ? 1 : 0));
            #endregion Usuario


        }
    }
}
