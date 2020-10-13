using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class MedicoEdicaoModel
    {
        [Required(ErrorMessage = "Por favor, informe o Id do médico. ")]
        public string IdMedico { get; set; }

        [MinLength(7, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do médico. ")]
        public string Nome { get; set; }

        [RegularExpression(@"^\d{2}\.\d{7}\-\d{1}$")]
        [Required(ErrorMessage = "Por favor, informe o CRM do médico. ")]
        public string Crm { get; set; }

        [MinLength(7, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a especialização do médico. ")]
        public string Especializacao { get; set; }
    }
}
