using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Escola.Application.DTOs.Usuario
{
    public class UsuarioPostDTO
    {
        [Required(ErrorMessage = "O nome do usuário é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O nome do usuário deve ter, no máximo 250 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email do usuário é obrigatório.")]
        [MaxLength(250, ErrorMessage = "O email deve ter, no máximo 250 caracteres.")]
        [EmailAddress(ErrorMessage = "O email do usuário deve ser um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A senha do usuário é obrigatória.")]
        [MinLength(8, ErrorMessage = "A senha do usuário deve ter, no mínimo, 8 caracteres.")]
        [MaxLength(250, ErrorMessage = "A senha deve ter, no máximo, 250 caracteres.")]
        public string Senha { get; set; }
    }
}
