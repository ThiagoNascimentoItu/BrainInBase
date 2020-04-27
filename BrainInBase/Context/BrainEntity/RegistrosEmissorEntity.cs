using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class RegistrosEmissorEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código do emissor é obrigatório")]
        public int EmissorCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do emissor é obrigatório")]
        public string EmissorIdentificador { get; set; }
        [Required(ErrorMessage = "O código do registro é obrigatório")]
        public int RegistrosCodigo { get; set; }
        [Required(ErrorMessage = "O código identificador do registro é obrigatório")]
        public string RegistrosIdentificador { get; set; }


    }
}
