using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class EmissorEntity
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "O código padrão do emissor é obrigatório")]
        public int Padrao { get; set; }
        [Required(ErrorMessage = "O código modificador o emissor é obrigatórios")]
        public int Modificador { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O código identificador do emissor é obrigatório")]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "O nome fantasia do emissor é obrigatório")]
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CpfCpnj { get; set; }
        public bool Ativo { get; set; }
        public string Url { get; set; }
    }
}
