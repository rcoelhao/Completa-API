namespace Completa_Contexto.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Feriado
    {
        [Key]
        public int Fer_Id { get; set; }

        [StringLength(50)]
        public string Fer_Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fer_Data { get; set; }
    }
}
