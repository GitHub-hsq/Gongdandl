/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Bbzx_RcjbbService与IBbzx_RcjbbService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Bbzx_RcjbbService : ServiceBase<Bbzx_Rcjbb, IBbzx_RcjbbRepository>
    , IBbzx_RcjbbService, IDependency
    {
    public Bbzx_RcjbbService(IBbzx_RcjbbRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IBbzx_RcjbbService Instance
    {
      get { return AutofacContainerModule.GetService<IBbzx_RcjbbService>(); } }
    }
 }
