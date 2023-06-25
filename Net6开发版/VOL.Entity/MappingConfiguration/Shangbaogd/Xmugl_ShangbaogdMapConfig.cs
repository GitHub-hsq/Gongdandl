using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Xmugl_ShangbaogdMapConfig : EntityMappingConfiguration<Xmugl_Shangbaogd>
    {
        public override void Map(EntityTypeBuilder<Xmugl_Shangbaogd>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

