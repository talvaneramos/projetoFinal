using Projeto.Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Application.Contracts
{
    public interface IAtendimentoApplicationService
    {
        void Insert(AtendimentoCadastroModel model);
        void Update(AtendimentoConsultaModel model);
        void Delete(int idAtendimento);

        List<AtendimentoConsultaModel> GetAll();
        AtendimentoConsultaModel GetById(int idAtendimento);
    }
}
