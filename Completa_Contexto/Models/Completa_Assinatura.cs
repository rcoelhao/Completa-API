namespace Completa_Contexto.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Completa_Assinatura : DbContext
    {
        public Completa_Assinatura()
            : base("name=Completa_Assinatura")
        {
        }

        public virtual DbSet<Completa_Assinaturas> Completa_Assinaturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
