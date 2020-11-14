namespace Completa_Contexto.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Completa_Contextoss : DbContext
    {
        public Completa_Contextoss()
            : base("name=Completa_Contexto")
        {
        }

        public virtual DbSet<Completa_Cliente> Completa_Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Documentos> Completa_Documentos { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Controllers.Completa_DatasBloqueadas> Completa_DatasBloqueadas { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Controllers.Completa_Feriado> Completa_Feriado { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Controllers.Completa_FeriadoEstadual> Completa_FeriadoEstadual { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Controllers.Completa_FeriadoMunicipal> Completa_FeriadoMunicipal { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Periodo> Completa_Periodo { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Unidade> Completa_Unidade { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Agendamento> Completa_Agendamento { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Auditoria> Completa_Auditoria { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Contratos> Completa_Contratos { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Autorizacao> Completa_Autorizacao { get; set; }

        public System.Data.Entity.DbSet<Completa_Contexto.Models.Completa_Assinaturas> Completa_Assinaturas { get; set; }

    }
}
