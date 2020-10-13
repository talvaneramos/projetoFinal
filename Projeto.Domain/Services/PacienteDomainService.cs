using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class PacienteDomainService : BaseDomainService<Paciente>, IPacienteDomainService
    {
        private IPacienteRepository pacienteRepository;

        public PacienteDomainService(IPacienteRepository pacienteRepository)
            : base(pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }

        public override void Insert(Paciente obj)
        {
            if(pacienteRepository.GetByCpf(obj.Cpf) == null)
            {
                pacienteRepository.Insert(obj);
            }
            else
            {
                throw new Exception("Erro, o CPF informado já consta na base de dados. ");
            }
        }

        public Paciente GetByCpf(string cpf)
        {
            return pacienteRepository.GetByCpf(cpf);
        }
    }
}
