using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Jczl_BfglMapConfig : EntityMappingConfiguration<Jczl_Bfgl>
    {
        public override void Map(EntityTypeBuilder<Jczl_Bfgl>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

