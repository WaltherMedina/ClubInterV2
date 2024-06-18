using AutoMapper;
using ClubInterV2.BLL.Servicios.Contrato;
using ClubInterV2.DAL.Repositorios.Contrato;
using ClubInterV2.DTO;
using ClubInterV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.BLL.Servicios
{
    public class RolService : IRolService
    {
        private readonly IGenericRepository<Trol> _rolRepository;
        private readonly IMapper _mapper;

        public RolService(IGenericRepository<Trol> rolRepository, IMapper mapper)
        {
            _rolRepository = rolRepository;
            _mapper = mapper;
        }

        public async Task<List<RolDTO>> Lista()
        {
            try {
                var listaRoles = await _rolRepository.GetAll();
                return _mapper.Map<List<RolDTO>>(listaRoles.ToList());
            }
            catch {
                throw;
            }
        }
    }
}
