using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBase.Query.Context.BrainEntity
{
    public class ComprovantesEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código padrão de usuário é obrigatório")]
        public int Padrao { get; set; }
        [Required(ErrorMessage = "O código modificador é obrigatórios")]
        public int Modificador { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O código identificador do comprovante é obrigatório")]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "A descrição do comprovante é obrigatório")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Deve ser informado a data de inclusão")]
        public DateTime DataInclusao { get; set; }
        [Required( ErrorMessage = "O tipo do documento deve ser informado")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Selecione um aquivo")]
        public byte[] Arquivo { get; set; }

    }
}
