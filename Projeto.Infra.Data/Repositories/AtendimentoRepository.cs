using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class AtendimentoRepository : BaseRepository<Atendimento>, IAtendimentoRepository
    {
        private readonly DataContext dataContext;

        public AtendimentoRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Atendimento> GetByLocal(string local)
        {
            return dataContext.Atendimento
                .Where(a => a.Local.Contains(local))
                .ToList();
        }
    }
}
