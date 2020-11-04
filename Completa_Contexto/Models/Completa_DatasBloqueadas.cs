namespace Completa_Contexto.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_DatasBloqueadas
    {
        [Key]
        public int Dat_Id { get; set; }

        [StringLength(50)]
        public string Dat_Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Dat_Data { get; set; }
    }
}
