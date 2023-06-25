/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Bbzx_WLluliRepository编写代码
 */
using VOL.Model.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Repositories
{
    public partial class Bbzx_WLluliRepository : RepositoryBase<Bbzx_WLluli> , IBbzx_WLluliRepository
    {
    public Bbzx_WLluliRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static IBbzx_WLluliRepository Instance
    {
      get {  return AutofacContainerModule.GetService<IBbzx_WLluliRepository>(); } }
    }
}
