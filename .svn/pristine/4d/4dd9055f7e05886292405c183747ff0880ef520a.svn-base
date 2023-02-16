using Persistence.Config;
using System.Data.Entity.ModelConfiguration;

namespace Persistence.Mappings
{
    public class RolMap : EntityTypeConfiguration<Rol>
    {
        public RolMap()
        {
            this.ToTable("Rol");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id_Num_Rol").IsRequired();
            this.Property(x => x.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired();
        }
    }
}
