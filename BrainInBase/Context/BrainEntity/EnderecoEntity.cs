using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class EnderecoEntity
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "A UF do endereço é obrigatório")]
        public string Uf { get; set; }
        [Required(ErrorMessage = "A cidade é obrigatório")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "O estado é obrigatório")]
        public string Estado { get; set; }
        [Required(ErrorMessage = "O tipo de lougradouro é obrigatório")]
        public string TipoLougradouro { get; set; }
        [Required(ErrorMessage = "O cecp é obrigatório")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O código padrão de usuário é obrigatório")]
        public int UsuariosPadrao { get; set; }
        [Required(ErrorMessage = "O código modificador usuáro é obrigatórios")]
        public int UsuariosModificador { get; set; }
        [Required(ErrorMessage = "O código do usuáro é obrigatorio")]
        public int UsuariosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do usuário é obrigatório")]
        public string UsuariosIdentificador { get; set; }

    }
}
