using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class Xmugl_XmubMapConfig : EntityMappingConfiguration<Xmugl_Xmub>
    {
        public override void Map(EntityTypeBuilder<Xmugl_Xmub>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

