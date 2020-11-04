using System;
using System.ComponentModel.DataAnnotations;

namespace Completa_Contexto.Models
{
    public partial class Completa_Autorizacao
    {
        [Key]
        public int Au_Id { get; set; }

        public int? Ct_Id { get; set; }

        public int? Au_Resposta { get; set; }

        public DateTime? Au_Data { get; set; }

        public int? Cli_Id { get; set; }
    }
}
