using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClubInterV2.DAL.Repositorios.Contrato;
using ClubInterV2.DAL.DBContext;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;


namespace ClubInterV2.DAL.Repositorios
{
    public class GenericRepository<TModelo>: IGenericRepository<TModelo> where TModelo : class
    {
        private readonly ClubinterV2Context _context;

        public GenericRepository(ClubinterV2Context context)
        {
            _context = context;
        }
        public async Task<TModelo> Get(Expression<Func<TModelo, bool>> filtro)
        {
            try
            {
                TModelo modelo = await _context.Set<TModelo>().FirstOrDefaultAsync(filtro);
                return modelo;
            }
            catch
            {
                throw;
            }
        }
        public async Task<TModelo> Create(TModelo modelo)
        {
            try
            {
                _context.Set<TModelo>().Add(modelo);
                await _context.SaveChangesAsync();
                return modelo;
            }
            catch
            {
                throw;
            }
        }
        public async Task<bool> Edit(TModelo modelo)
        {
            try
            {
                _context.Set<TModelo>().Update(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public async Task<bool> Delete(TModelo modelo)
        {
            try
            {
                _context.Set<TModelo>().Remove(modelo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                throw;
            }
        }
        public async Task<IQueryable<TModelo>> GetAll(Expression<Func<TModelo, bool>> filtro = null)
        {
            try
            {
                IQueryable<TModelo> queryModelo = filtro == null ? _context.Set<TModelo>(): _context.Set<TModelo>().Where(filtro);
                return queryModelo;
            }
            catch
            {
                throw;
            }
        }
    }
}
