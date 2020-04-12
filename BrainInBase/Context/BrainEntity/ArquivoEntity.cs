using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class ArquivoEntity
    {
        [Key]
        public string Id{ get; set; }
        [Required(ErrorMessage = "O código padrão do registro é obrigatório")]
        public int RegistrosPadrao { get; set; }
        [Required(ErrorMessage = "O código modificador é obrigatórios")]
        public int RegistrosModificador { get; set; }
        [Required(ErrorMessage = "O código do registro é obrigatório")]
        public int RegistrosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do registro é obrigatório")]
        public string RegistrosIdentificador { get; set; }

        public byte[] Arquivos { get; set; }
    }
}
