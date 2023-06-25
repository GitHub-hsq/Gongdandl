using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Xmugl_XmulbMapConfig : EntityMappingConfiguration<Xmugl_Xmulb>
    {
        public override void Map(EntityTypeBuilder<Xmugl_Xmulb>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

