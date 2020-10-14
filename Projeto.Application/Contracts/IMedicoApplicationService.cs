using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    interface IMedicoApplicationService
    {
        void Insert(MedicoCadastroModel model);
        void Update(MedicoEdicaoModel model);
        void Delete(int idMedico);

        List<MedicoConsultaModel> GetAll();
        MedicoConsultaModel GetById(int idMedico);
    }
}
