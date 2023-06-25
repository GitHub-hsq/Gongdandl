/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Gdgl_XjrbRepository编写代码
 */
using VOL.Model.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Repositories
{
    public partial class Gdgl_XjrbRepository : RepositoryBase<Gdgl_Xjrb> , IGdgl_XjrbRepository
    {
    public Gdgl_XjrbRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IGdgl_XjrbRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IGdgl_XjrbRepository>(); } }
    }
}
