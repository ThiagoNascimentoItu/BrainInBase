using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class RegistrosEntity
    {
        [Key]
        public string Id { get; set; }
        [Required(ErrorMessage = "O código padrão de usuário é obrigatório")]
        public int Padrao { get; set; }
        [Required(ErrorMessage = "O código modificador é obrigatórios")]
        public int Modificador { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O código identificador do registro é obrigatório")]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "A descrição do registro é obrigatório")]
        public string Descricao { get; set; }
        public decimal CargaHoraria { get; set; }
        public string ChaveValidacao { get; set; }
        public string Url { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime DataConclusao { get; set; }
        public int Validade { get; set; }
        public string TipoRegistro { get; set; }

    }
}
