using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClubInterV2.Model;

namespace ClubInterV2.DAL.Repositorios.Contrato
{
    public interface IDeudaRepository:IGenericRepository<TcomprobanteDeuda>
    {
        Task<TcomprobanteDeuda> Registrar(TcomprobanteDeuda modelo);
    }
}
