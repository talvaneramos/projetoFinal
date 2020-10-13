using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class AtendimentoEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o Id do Atendimento. ")]
        public string IdAtendimento { get; set; }

        [RegularExpression(@"^(?: (?: 31(\/| -|\.)(?:0?[13578] | 1[02] | (?: Jan | Mar | May | Jul | Aug | Oct | Dec)))\1 | (?: (?: 29 | 30)(\/| -|\.)(?:0?[1, 3 - 9] | 1[0 - 2] | (?: Jan | Mar | Apr | May | Jun | Jul | Aug | Sep | Oct | Nov | Dec))\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)(?:0?2|(?:Feb))\3(?:(?:(?:1[6-9]|[2-9]\d)? (?:0[48]|[2468] [048]|[13579] [26])|(?:(?:16|[2468] [048]|[3579] [26])00))))$|^(?:0?[1 - 9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1 - 9]|(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep))|(?:1[0-2]|(?:Oct|Nov|Dec)))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$",
                 ErrorMessage = "Por favor, informe a data de atendimento correta")]
        [Required(ErrorMessage = "Por favor, informe a data de atendimento do paciente. ")]
        public string DataAtendimento { get; set; }


        [MinLength(7, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o local. ")]
        public string Local { get; set; }


        [MinLength(7, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(1200, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a observação. ")]
        public string Observacoes { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id do Médico. ")]
        public string IdMedico { get; set; }

        [Required(ErrorMessage = "Por favor, informe o Id do Paciente. ")]
        public string IdPaciente { get; set; }
    }
}
