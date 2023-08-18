﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace APP.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

       // [Required(ErrorMessage = "O campo {0} é obrigatório")]
       // [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Email { get; set; }

       // [Required(ErrorMessage = "O campo {0} é obrigatório")]
       // [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Telefone { get; set; }

        public DateTime Dt_Cadastro { get; set; }

    }

}
