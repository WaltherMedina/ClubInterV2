using ClubInterV2.DAL.DBContext;
using ClubInterV2.DAL.Repositorios.Contrato;
using ClubInterV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.DAL.Repositorios
{
    public class DeudaRepository : GenericRepository<TcomprobanteDeuda>//, IDeudaRepository
    {
        private readonly ClubinterV2Context _context;

        public DeudaRepository(ClubinterV2Context context):base(context)
        {
            _context = context;
        }

        
    }
}
