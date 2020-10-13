using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Application.Models
{
    public class PacienteCadastroModel
    {
        [MinLength(7, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do paciente. ")]
        public string Nome { get; set; }



        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o cpf do paciente. ")]
        public string Cpf { get; set; }


        [RegularExpression(@"^(?: (?: 31(\/| -|\.)(?:0?[13578] | 1[02] | (?: Jan | Mar | May | Jul | Aug | Oct | Dec)))\1 | (?: (?: 29 | 30)(\/| -|\.)(?:0?[1, 3 - 9] | 1[0 - 2] | (?: Jan | Mar | Apr | May | Jun | Jul | Aug | Sep | Oct | Nov | Dec))\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)(?:0?2|(?:Feb))\3(?:(?:(?:1[6-9]|[2-9]\d)? (?:0[48]|[2468] [048]|[13579] [26])|(?:(?:16|[2468] [048]|[3579] [26])00))))$|^(?:0?[1 - 9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1 - 9]|(?:Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep))|(?:1[0-2]|(?:Oct|Nov|Dec)))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$",
                  ErrorMessage = "Por favor, informe a data de nascimento correta")]
        [Required(ErrorMessage = "Por favor, informe a data de nascimento do paciente. ")]
        public string DataNascimento { get; set; }


        [RegularExpression(@"^[0 - 9]{2}-[0-9]{4}-[0 - 9]{ 4}$")]
        [Required(ErrorMessage = "Por favor, informe o telefone do paciente. ")]
        public string Telefone { get; set; }



        [RegularExpression(@"^[-a-zA-Z0-9][-.a-zA-Z0-9]*@[-.a-zA-Z0-9]+(\.[-.a-zA-Z0-9]+)*\.(com|edu|info|gov|int|mil|net|org|biz|name|museum|coop|aero|pro|tv|[a-zA-Z]{2})$")]
        [Required(ErrorMessage = "Por favor, informe o email do paciente. ")]
        public string Email { get; set; }
    }
}
