using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Entities;
using Projeto.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class PacienteRepository : BaseRepository<Paciente>, IPacienteRepository
    {
        private readonly DataContext dataContext;

        public PacienteRepository(DataContext dataContext)
            : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Paciente GetByCpf(string cpf)
        {
            return dataContext.Paciente
                .FirstOrDefault(p => p.Cpf.Equals(cpf));
        }
    }
}
