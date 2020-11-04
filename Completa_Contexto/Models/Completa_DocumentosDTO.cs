using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Completa_Contexto.Models
{
    public partial class Completa_DocumentosDTO
    {
        public int Doc_Id { get; set; }

        public string Doc_Nome { get; set; }

        public int Cli_Id { get; set; }

        public int? Tip_Id { get; set; }

        public int? Doc_Aud { get; set; }
    }
}
