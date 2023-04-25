using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projeto01.Domain.Entities;

namespace Projeto01.Domain.Contracts.Repositories
{
    public interface IEmpresaRepository
        : IBaseRepository<Empresa, Guid>
    {

    }
}