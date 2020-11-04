namespace Completa_Contexto.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Completa_Cliente
    {
        [Key]
        public int Cli_Id { get; set; }

        [StringLength(100)]
        public string Cli_Nome { get; set; }

        [StringLength(50)]
        public string Cli_Cpf { get; set; }

        [StringLength(50)]
        public string Cli_Rg { get; set; }

        [StringLength(150)]
        public string Cli_End { get; set; }

        public int? Bai_Id { get; set; }

        public int? Cid_Id { get; set; }

        public int? Est_Id { get; set; }

        [StringLength(9)]
        public string Cli_Cep { get; set; }

        [StringLength(20)]
        public string Cli_Tel { get; set; }

        [StringLength(20)]
        public string Cli_Cel { get; set; }

        public bool? Cli_Status { get; set; }

        [StringLength(50)]
        public string Cli_Email { get; set; }

        [StringLength(10)]
        public string Cli_senha { get; set; }

        public bool? Cli_PJ { get; set; }
    }
}
