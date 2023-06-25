using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Gdgl_XjrbMapConfig : EntityMappingConfiguration<Gdgl_Xjrb>
    {
        public override void Map(EntityTypeBuilder<Gdgl_Xjrb>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

