/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Ccgl_WLckuRepository编写代码
 */
using VOL.Model.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Repositories
{
    public partial class Ccgl_WLckuRepository : RepositoryBase<Ccgl_WLcku> , ICcgl_WLckuRepository
    {
    public Ccgl_WLckuRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static ICcgl_WLckuRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ICcgl_WLckuRepository>(); } }
    }
}
