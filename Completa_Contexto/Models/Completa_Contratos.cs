using System.ComponentModel.DataAnnotations;

namespace Completa_Contexto.Models
{
    public partial class Completa_Contratos
    {
        [Key]
        public int Ct_Id { get; set; }

        [StringLength(50)]
        public string Ct_Nome { get; set; }

        public string Ct_Texto { get; set; }
    }
}
