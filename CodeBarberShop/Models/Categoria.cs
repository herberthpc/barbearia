using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeBarberShop.Models
{
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome é obrigatório" )]
        public string Nome { get; set; }
        [DisplayName("Criado em")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        [DisplayName("Última alteração")]
        public DateTime DataAlteracao {get; set; } = DateTime.Now;
    }
}