using Projeto.Application.Contracts;
using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Entities;
using Microsoft.VisualBasic;
using Projeto.Domain.Services;

namespace Projeto.Application.Services
{
    public class PacienteApplicationService : IPacienteApplicationService
    {
        private readonly IPacienteDomainService pacienteDomainService;

        public PacienteApplicationService(IPacienteDomainService pacienteDomainService)
        {
            this.pacienteDomainService = pacienteDomainService;
        }

        public void Insert(PacienteCadastroModel model)
        {
            var paciente = new Paciente();

            paciente.Nome = model.Nome;
            paciente.Cpf = model.Cpf;
            paciente.DataNascimento = DateTime.Parse(model.DataNascimento);
            paciente.Telefone = model.Telefone;
            paciente.Email = model.Email;

            pacienteDomainService.Insert(paciente);
        }

        public void Update(PacienteEdicaoModel model)
        {
            var paciente = new Paciente();

            paciente.IdPaciente = int.Parse(model.IdPaciente);
            paciente.Nome = model.Nome;
            paciente.Cpf = model.Cpf;
            paciente.DataNascimento = DateTime.Parse(model.DataNascimento);
            paciente.Telefone = model.Telefone;
            paciente.Email = model.Email;

            pacienteDomainService.Update(paciente);
        }

        public void Delete(int idPaciente)
        {
            var paciente = pacienteDomainService.GetById(idPaciente);
            pacienteDomainService.Delete(paciente);
        }

        public List<PacienteConsultaModel> GetAll()
        {
            var lista = new List<PacienteConsultaModel>();

            foreach (var item in pacienteDomainService.GetAll())
            {
                var model = new PacienteConsultaModel();

                model.IdPaciente = item.IdPaciente.ToString();
                model.Nome = item.Nome;
                model.Cpf = item.Cpf;
                model.DataNascimento = item.DataNascimento.ToString();
                model.Telefone = item.Telefone;
                model.Email = item.Email;
            }
            return lista;
        }

        public PacienteConsultaModel GetById(int idPaciente)
        {
            var paciente = pacienteDomainService.GetById(idPaciente);

            var model = new PacienteConsultaModel();

            model.IdPaciente = paciente.IdPaciente.ToString();
            model.Nome = paciente.Nome;
            model.Cpf = paciente.Cpf;
            model.DataNascimento = paciente.DataNascimento.ToString();
            model.Telefone = paciente.Telefone;
            model.Email = paciente.Email;

            return model;
        }
    }
}
