using Persistence.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mappings
{
    public class MesMap : EntityTypeConfiguration<Mes>
    {
        public MesMap()
        {
            this.ToTable("Mes");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id_Num_Mes").IsRequired();
            this.Property(x => x.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired();
        }
    }
}
