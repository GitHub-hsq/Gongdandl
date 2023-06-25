using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Jczl_WLglMapConfig : EntityMappingConfiguration<Jczl_WLgl>
    {
        public override void Map(EntityTypeBuilder<Jczl_WLgl>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

