namespace Completa_Contexto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Auditoria
    {
        [Key]
        public int Aud_Id { get; set; }

        public int? Cli_Id { get; set; }

        [StringLength(100)]
        public string Aud_Obs { get; set; }

        public bool? Aud_Aprovado { get; set; }
    }
}
