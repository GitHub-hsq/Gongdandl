/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Ccgl_WLrkuService与ICcgl_WLrkuService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Ccgl_WLrkuService : ServiceBase<Ccgl_WLrku, ICcgl_WLrkuRepository>
    , ICcgl_WLrkuService, IDependency
    {
    public Ccgl_WLrkuService(ICcgl_WLrkuRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICcgl_WLrkuService Instance
    {
      get { return AutofacContainerModule.GetService<ICcgl_WLrkuService>(); } }
    }
 }
