using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Jczl_RyglMapConfig : EntityMappingConfiguration<Jczl_Rygl>
    {
        public override void Map(EntityTypeBuilder<Jczl_Rygl>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

