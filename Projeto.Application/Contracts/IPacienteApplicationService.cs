using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IPacienteApplicationService
    {
        void Insert(PacienteCadastroModel model);
        void Update(PacienteEdicaoModel model);
        void Delete(int idPaciente);

        List<PacienteConsultaModel> GetAll();
        PacienteConsultaModel GetById(int idPaciente);
    }
}
