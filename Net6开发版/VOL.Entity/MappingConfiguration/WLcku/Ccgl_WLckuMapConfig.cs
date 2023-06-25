using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Ccgl_WLckuMapConfig : EntityMappingConfiguration<Ccgl_WLcku>
    {
        public override void Map(EntityTypeBuilder<Ccgl_WLcku>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

