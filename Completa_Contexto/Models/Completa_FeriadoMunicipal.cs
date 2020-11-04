namespace Completa_Contexto.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_FeriadoMunicipal
    {
        [Key]
        public int Fem_Id { get; set; }

        [StringLength(50)]
        public string Fem_Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fem_Data { get; set; }

        public int? Cid_Id { get; set; }
    }
}
