using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgDeViagens.Models
{
    public class Promocao
    {
        [Key]

        public int Id { get; set; }

        [Required]
        public string NomePromocao { get; set; }

        [Required]
        public double ValorDesconto { get; set; }



        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public virtual Destino Destino { get; set; }

    }
}
