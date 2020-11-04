using System.ComponentModel.DataAnnotations;

namespace Completa_Contexto.ViewModel
{
    public class Completa_DocumentosID
    {
       
        [Key]
        public int Doc_Id { get; set; }

        public int Cli_Id { get; set; }

        public int? Doc_Aud { get; set; }

        

    }
}