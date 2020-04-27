using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBase.Query.Context.BrainEntity
{
    public class RegistrosEmissorEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código padrão do emissor é obrigatório")]
        public int EmissorPadrao { get; set; }
        [Required(ErrorMessage = "O código modificador o emissor é obrigatórios")]
        public int EmissorModificador { get; set; }
        [Required(ErrorMessage = "O código do emissor é obrigatório")]
        public int EmissorCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do emissor é obrigatório")]
        public string EmissorIdentificador { get; set; }
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
