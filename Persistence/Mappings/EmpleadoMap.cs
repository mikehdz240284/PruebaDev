using Persistence.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mappings
{
    public class EmpleadoMap : EntityTypeConfiguration<Empleado>
    {
    
        public EmpleadoMap()
        {
            this.ToTable("Empleado");
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasColumnName("Id_Num_Empleado").IsRequired();
            this.Property(x => x.Nombre).HasColumnName("Nombre").HasMaxLength(100).IsRequired();
            this.Property(x => x.NumeroEmpleado).HasColumnName("NumeroEmpleado").HasMaxLength(50).IsRequired();
            this.Property(x => x.Id_Num_Rol).HasColumnName("Id_Num_Rol").IsRequired();
            this.Ignore(x => x.NombreRol);
        }
    }
}
