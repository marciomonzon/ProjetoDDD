using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.User
{
    public class UserDto
    {
        [Required(ErrorMessage = "Nome é campo obrigatório")]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} carateceres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail é campo obrigatório")]
        [EmailAddress(ErrorMessage = "E-mail inválido!")]
        [StringLength(100, ErrorMessage = "E-mail deve ter no máximo {1} carateceres.")]
        public string Email { get; set; }
    }
}
