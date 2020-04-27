using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBase.Query.Context.BrainEntity
{
    public class UsuariosRegistrosEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código padrão de usuário é obrigatório")]
        public int UsuariosPadrao { get; set; }
        [Required(ErrorMessage = "O código modificador usuáro é obrigatórios")]
        public int UsuariosModificador { get; set; }
        [Required(ErrorMessage = "O código do usuáro é obrigatorio")]
        public int UsuariosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do usuário é obrigatório")]
        public string UsuariosIdentificador { get; set; }
        [Required(ErrorMessage = "O código padrão do registro é obrigatório")]
        public int RegistrosPadrao { get; set; }
        [Required(ErrorMessage = "O código modificador é obrigatórios")]
        public int RegistrosModificador { get; set; }
        [Required(ErrorMessage = "O código do registro é obrigatório")]
        public int RegistrosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do registro é obrigatório")]
        public string RegistrosIdentificador { get; set; }


    }
}
