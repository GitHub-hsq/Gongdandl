using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Ccgl_WLrkuMapConfig : EntityMappingConfiguration<Ccgl_WLrku>
    {
        public override void Map(EntityTypeBuilder<Ccgl_WLrku>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

