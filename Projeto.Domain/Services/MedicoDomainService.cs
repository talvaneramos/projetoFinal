using Projeto.Domain.Contracts.Repositories;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Services
{
    public class MedicoDomainService : BaseDomainService<Medico>, IMedicoDomainService
    {
        private readonly IMedicoRepository medicoRepository;

        public MedicoDomainService(IMedicoRepository medicoRepository)
            : base(medicoRepository)
        {
            this.medicoRepository = medicoRepository;
        }

        public override void Insert(Medico obj)
        {
            if(medicoRepository.GetByCrm(obj.Crm) == null)
            {
                medicoRepository.Insert(obj);
            }
            else
            {
                throw new Exception("Erro, o CRM informado já consta na base da dados. ");
            }
        }

        public Medico GetByCrm(string crm)
        {
            return medicoRepository.GetByCrm(crm);
        }
    }
}
