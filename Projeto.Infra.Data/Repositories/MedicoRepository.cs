using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class MedicoRepository : BaseRepository<Medico>, IMedicoRepository
    {
        private readonly DataContext dataContext;

        public MedicoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Medico GetByCrm(string crm)
        {
            return dataContext.Medico
                .FirstOrDefault(m => m.Crm.Equals(crm));
        }
    }
}
