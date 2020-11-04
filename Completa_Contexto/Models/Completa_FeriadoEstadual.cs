namespace Completa_Contexto.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_FeriadoEstadual
    {
        [Key]
        public int FerEst_Id { get; set; }

        [StringLength(50)]
        public string FerEst_Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FerEst_Data { get; set; }

        public int? Est_Id { get; set; }
    }
}
