namespace Completa_Contexto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Agendamento
    {
        [Key]
        public int Age_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Age_Data { get; set; }

        [StringLength(50)]
        public string Age_Obs { get; set; }

        public int? Ast_Id { get; set; }

        public int? Cli_Id { get; set; }

        public int? Per_Id { get; set; }
    }
}
