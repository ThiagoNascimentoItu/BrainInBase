using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BrainInBaseApi.Context.BrainEntity
{
    public class UsuariosEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O código padrão de usuário é obrigatório")]
        public int Padrao { get; set; }
        [Required(ErrorMessage = "O código modificador é obrigatórios")]
        public int Modificador { get; set; }
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O código identificador do usuário é obrigatório")]
        public string Identificador { get; set; }
        [Required(ErrorMessage = "O nome do usuário é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O sobrenome do usuário é obrigatório")]
        public string Sobrenome { get; set; }
        [Required(ErrorMessage = "O E-mail do usuário é obrigatrio")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A data de nascimento é um campo obrigatório")]
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}
