using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Completa_Contexto.Models
{
    public partial class Completa_Documentos
    {
        [Key]
        public int Doc_Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Doc_Dados { get; set; }

        [StringLength(50)]
        public string Doc_Nome { get; set; }

        [StringLength(50)]
        public string Doc_ContentType { get; set; }

        public int Cli_Id { get; set; }

        public int? Tip_Id { get; set; }

        public int? Doc_Aud { get; set; }

        public float? Doc_Long { get; set; }

        public float? Doc_Lat { get; set; }
    }
}
