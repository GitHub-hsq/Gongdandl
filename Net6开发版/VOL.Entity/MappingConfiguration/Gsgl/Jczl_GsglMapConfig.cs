using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Jczl_GsglMapConfig : EntityMappingConfiguration<Jczl_Gsgl>
    {
        public override void Map(EntityTypeBuilder<Jczl_Gsgl>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

