using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Completa_Contexto.Models
{
    public class Completa_Doc

    {
        [Key]
        public int Doc_Id { get; set; }

       

        [StringLength(50)]
        public string Doc_Nome { get; set; }

       

        public int Cli_Id { get; set; }

       
    }

}