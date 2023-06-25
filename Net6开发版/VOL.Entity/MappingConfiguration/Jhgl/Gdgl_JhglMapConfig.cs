using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Gdgl_JhglMapConfig : EntityMappingConfiguration<Gdgl_Jhgl>
    {
        public override void Map(EntityTypeBuilder<Gdgl_Jhgl>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

