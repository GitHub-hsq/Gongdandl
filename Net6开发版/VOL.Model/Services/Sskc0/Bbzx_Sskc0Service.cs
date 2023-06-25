/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Bbzx_Sskc0Service与IBbzx_Sskc0Service中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Bbzx_Sskc0Service : ServiceBase<Bbzx_Sskc0, IBbzx_Sskc0Repository>
    , IBbzx_Sskc0Service, IDependency
    {
    public Bbzx_Sskc0Service(IBbzx_Sskc0Repository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IBbzx_Sskc0Service Instance
    {
      get { return AutofacContainerModule.GetService<IBbzx_Sskc0Service>(); } }
    }
 }
