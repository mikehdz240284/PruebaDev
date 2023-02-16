using Persistence.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mappings
{
    public class MovimientoMap : EntityTypeConfiguration<Movimiento>
    {
        public MovimientoMap()
        {
            this.ToTable("Movimiento");
            this.Property(x => x.Id_Num_Empleado).HasColumnName("Id_Num_Empleado").IsRequired();
            this.Property(x => x.Id_Num_Mes).HasColumnName("Id_Num_Mes").IsRequired();
            this.Property(x => x.Horas_Trabajadas).HasColumnName("Horas_Trabajadas").IsRequired();
            this.Property(x => x.Cant_Entrega).HasColumnName("Cant_Entrega").IsRequired();            
        }

    }
}
