using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Bbzx_WLluliMapConfig : EntityMappingConfiguration<Bbzx_WLluli>
    {
        public override void Map(EntityTypeBuilder<Bbzx_WLluli>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

