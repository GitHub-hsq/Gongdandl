using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Bbzx_RcjbbMapConfig : EntityMappingConfiguration<Bbzx_Rcjbb>
    {
        public override void Map(EntityTypeBuilder<Bbzx_Rcjbb>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

