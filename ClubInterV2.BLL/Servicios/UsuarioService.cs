using AutoMapper;
using ClubInterV2.BLL.Servicios.Contrato;
using ClubInterV2.DAL.Repositorios.Contrato;
using ClubInterV2.DTO;
using ClubInterV2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.BLL.Servicios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IGenericRepository<Tusuario> _usuarioRepository;
        private readonly IMapper _mapper;

        public UsuarioService(IGenericRepository<Tusuario> usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        public async Task<List<UsuarioDTO>> Lista()
        {
            try
            {
                var queryUsuario = await _usuarioRepository.GetAll();
                var listaUsuarios = queryUsuario.Include(rol => rol.Role).ToList();

                return _mapper.Map<List<UsuarioDTO>>(listaUsuarios);
            }
            catch
            {
                throw;
            }
        }
        public async Task<SesionDTO> ValidarCredenciales(string correo, string clave)
        {
            try
            {
                var queryUsuario = await _usuarioRepository.GetAll(u =>
                    u.Usercorreo == correo &&
                    u.Usercontrasena == clave);
                if (queryUsuario.FirstOrDefault() == null)
                    throw new TaskCanceledException("El usuario no existe");

                Tusuario devolverUsuario = queryUsuario.Include(rol => rol.Role).First();

                return _mapper.Map<SesionDTO>(devolverUsuario);
            }
            catch
            {
                throw;
            }
        }
        public async Task<UsuarioDTO> Crear(UsuarioDTO modelo)
        {
            try
            {
                var usuarioCreado = await _usuarioRepository.Create(_mapper.Map<Tusuario>(modelo));

                if (usuarioCreado.Userid == 0)
                    throw new TaskCanceledException("No se pudo crear");

                var query = await _usuarioRepository.GetAll(u => u.Userid == usuarioCreado.Userid);

                usuarioCreado = query.Include(rol => rol.Role).First();
                
                return _mapper.Map<UsuarioDTO>(usuarioCreado);
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Editar(UsuarioDTO modelo)
        {
            try
            {
                var usuarioModelo = _mapper.Map<Tusuario>(modelo);
                var usuarioEncontrado = await _usuarioRepository.Get(u => u.Userid == usuarioModelo.Userid);
                if (usuarioEncontrado == null)
                    throw new TaskCanceledException("El usuario no existe");

                usuarioEncontrado.Usercorreo = usuarioModelo.Usercorreo;
                usuarioEncontrado.Usercontrasena = usuarioModelo.Usercontrasena;
                usuarioEncontrado.Userestado = usuarioModelo.Userestado;

                bool respuesta = await _usuarioRepository.Edit(usuarioEncontrado);
                if (!respuesta)
                    throw new TaskCanceledException("No se pudo editar");

                return respuesta;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Eliminar(int id)
        {
            try
            {
                var usuarioEncontrado = await _usuarioRepository.Get(u => u.Userid == id);
                if (usuarioEncontrado == null)
                    throw new TaskCanceledException("El usuario no existe");

                bool respuesta = await _usuarioRepository.Delete(usuarioEncontrado);

                if (!respuesta)
                    throw new TaskCanceledException("No se pudo eliminar");

                return respuesta;
            }
            catch
            {
                throw;
            }
        }

        
    }
}
