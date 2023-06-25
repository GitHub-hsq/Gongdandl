/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹Ccgl_JxtzRepository编写代码
 */
using VOL.Model.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Repositories
{
    public partial class Ccgl_JxtzRepository : RepositoryBase<Ccgl_Jxtz> , ICcgl_JxtzRepository
    {
    public Ccgl_JxtzRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static ICcgl_JxtzRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ICcgl_JxtzRepository>(); } }
    }
}
