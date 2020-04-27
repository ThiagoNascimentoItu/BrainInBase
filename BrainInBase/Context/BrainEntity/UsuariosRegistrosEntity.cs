using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class UsuariosRegistrosEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código do usuáro é obrigatorio")]
        public int UsuariosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do usuário é obrigatório")]
        public string UsuariosIdentificador { get; set; }
        [Required(ErrorMessage = "O código do registro é obrigatório")]
        public int RegistrosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do registro é obrigatório")]
        public string RegistrosIdentificador { get; set; }


    }
}
