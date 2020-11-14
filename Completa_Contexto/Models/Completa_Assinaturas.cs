using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Completa_Contexto.Models
{
    public partial class Completa_Assinaturas
    {
        [Key]
        public int Ass_Id { get; set; }

        public int Cli_Id { get; set; }

        [Column(TypeName = "image")]
        public byte[] Ass_image { get; set; }

    }
}
