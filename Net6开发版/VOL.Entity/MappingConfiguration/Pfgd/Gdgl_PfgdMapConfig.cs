using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Gdgl_PfgdMapConfig : EntityMappingConfiguration<Gdgl_Pfgd>
    {
        public override void Map(EntityTypeBuilder<Gdgl_Pfgd>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

