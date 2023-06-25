using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Ccgl_JxtzMapConfig : EntityMappingConfiguration<Ccgl_Jxtz>
    {
        public override void Map(EntityTypeBuilder<Ccgl_Jxtz>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

