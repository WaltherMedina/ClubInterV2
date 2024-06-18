using ClubInterV2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubInterV2.BLL.Servicios.Contrato
{
    public interface IRolService
    {
        Task<List<RolDTO>> Lista();
    }
}
