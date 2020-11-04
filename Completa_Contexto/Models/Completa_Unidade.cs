namespace Completa_Contexto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Unidade
    {
        [Key]
        public int Uni_Id { get; set; }

        [StringLength(50)]
        public string Uni_Nome { get; set; }

        public int? Cid_Id { get; set; }

        public int? Uni_Tecnicos { get; set; }

        public int? Uni_PerManha { get; set; }

        public int? Uni_PerTarde { get; set; }

        public int? Uni_PerNoite { get; set; }
    }
}
