using Projeto.Application.Contracts;
using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;

namespace Projeto.Application.Services
{
    public class MedicoApplicationService : IMedicoApplicationService
    {
        private readonly IMedicoDomainService medicoDomainService;

        public MedicoApplicationService(IMedicoDomainService medicoDomainService)
        {
            this.medicoDomainService = medicoDomainService;
        }

        public void Insert(MedicoCadastroModel model)
        {
            var medico = new Medico();

            medico.Nome = model.Nome;
            medico.Crm = model.Crm;
            medico.Especializacao = model.Especializacao;

            medicoDomainService.Insert(medico);
        }

        public void Update(MedicoEdicaoModel model)
        {
            var medico = new Medico();

            medico.IdMedico = int.Parse(model.IdMedico);
            medico.Nome = model.Nome;
            medico.Crm = model.Crm;
            medico.Especializacao = model.Especializacao;

            medicoDomainService.Update(medico);
        }

        public void Delete(int idMedico)
        {
            var medico = medicoDomainService.GetById(idMedico);
            medicoDomainService.Delete(medico);
        }

        public List<MedicoConsultaModel> GetAll()
        {
            var lista = new List<MedicoConsultaModel>();

            foreach (var item in medicoDomainService.GetAll())
            {
                var model = new MedicoConsultaModel();

                model.IdMedico = item.IdMedico.ToString();
                model.Nome = item.Nome;
                model.Crm = item.Crm;
                model.Especializacao = item.Especializacao;
            }

            return lista;
        }

        public MedicoConsultaModel GetById(int idMedico)
        {
            var medico = medicoDomainService.GetById(idMedico);

            var model = new MedicoConsultaModel();

            model.IdMedico = medico.IdMedico.ToString();
            model.Nome = medico.Nome;
            model.Crm = medico.Crm;
            model.Especializacao = medico.Especializacao;

            return model;
        }
    }
}
