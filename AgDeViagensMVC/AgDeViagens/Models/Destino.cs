using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgDeViagens.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Local { get; set; }

        public string Data { get; set; }

        public double Valor { get; set; }




        public virtual ICollection<Promocao> Promocao { get; set; }


    }
}
