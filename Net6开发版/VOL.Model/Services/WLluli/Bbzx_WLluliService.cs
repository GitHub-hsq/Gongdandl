/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Bbzx_WLluliService与IBbzx_WLluliService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Bbzx_WLluliService : ServiceBase<Bbzx_WLluli, IBbzx_WLluliRepository>
    , IBbzx_WLluliService, IDependency
    {
    public Bbzx_WLluliService(IBbzx_WLluliRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IBbzx_WLluliService Instance
    {
      get { return AutofacContainerModule.GetService<IBbzx_WLluliService>(); } }
    }
 }
