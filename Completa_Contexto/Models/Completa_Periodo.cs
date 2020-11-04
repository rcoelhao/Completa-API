namespace Completa_Contexto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Periodo
    {
        [Key]
        public int Per_Id { get; set; }

        [StringLength(50)]
        public string Per_Nome { get; set; }

        public int? Per_Limite { get; set; }

        public int? Uni_Id { get; set; }
    }
}
