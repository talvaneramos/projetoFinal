using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Services
{
    public class AtendimentoApplicationService : IAtendimentoApplicationService
    {
        private readonly IAtendimentoDomainService atendimentoDomainService;

        public AtendimentoApplicationService(IAtendimentoDomainService atendimentoDomainService)
        {
            this.atendimentoDomainService = atendimentoDomainService;
        }

        public void Insert(AtendimentoCadastroModel model)
        {
            var atendimento = new Atendimento();

            atendimento.DataAtendimento = DateTime.Parse(model.DataAtendimento);
            atendimento.Local = model.Local;
            atendimento.Observacoes = model.Observacoes;
            atendimento.IdMedico = int.Parse(model.IdMedico);
            atendimento.IdPaciente = int.Parse(model.IdPaciente);
 
            atendimentoDomainService.Insert(atendimento);
        }

        public void Update(AtendimentoConsultaModel model)
        {
            var atendimento = new Atendimento();

            atendimento.IdAtendimento = int.Parse(model.IdAtendimento);
            atendimento.DataAtendimento = DateTime.Parse(model.DataAtendimento);
            atendimento.Local = model.Local;
            atendimento.Observacoes = model.Observacoes;
            atendimento.IdMedico = int.Parse(model.IdMedico);
            atendimento.IdPaciente = int.Parse(model.IdPaciente);

            atendimentoDomainService.Update(atendimento);
        }

        public void Delete(int idAtendimento)
        {
            var atendimento = atendimentoDomainService.GetById(idAtendimento);
            atendimentoDomainService.Delete(atendimento);

        }

        public List<AtendimentoConsultaModel> GetAll()
        {
            var lista = new List<AtendimentoConsultaModel>();

            foreach (var item in atendimentoDomainService.GetAll())
            {
                var model = new AtendimentoConsultaModel();

                model.IdAtendimento = item.IdAtendimento.ToString();
                model.DataAtendimento = item.DataAtendimento.ToString();
                model.Local = item.Local;
                model.Observacoes = item.Observacoes;
                model.IdMedico = item.IdMedico.ToString();
                model.IdPaciente = item.IdPaciente.ToString();

                lista.Add(model);

            }

            return lista;
        }

        public AtendimentoConsultaModel GetById(int idAtendimento)
        {
            var atendimento = atendimentoDomainService.GetById(idAtendimento);
            var model = new AtendimentoConsultaModel();

            model.IdAtendimento = atendimento.IdAtendimento.ToString();
            model.DataAtendimento = atendimento.DataAtendimento.ToString();
            model.Local = atendimento.Local;
            model.Observacoes = atendimento.Observacoes;
            model.IdMedico = atendimento.IdMedico.ToString();
            model.IdPaciente = atendimento.IdPaciente.ToString();

            return model;

        }
    }
}
