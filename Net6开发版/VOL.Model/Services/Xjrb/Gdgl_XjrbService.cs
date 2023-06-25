/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Gdgl_XjrbService与IGdgl_XjrbService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Gdgl_XjrbService : ServiceBase<Gdgl_Xjrb, IGdgl_XjrbRepository>
    , IGdgl_XjrbService, IDependency
    {
    public Gdgl_XjrbService(IGdgl_XjrbRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IGdgl_XjrbService Instance
    {
      get { return AutofacContainerModule.GetService<IGdgl_XjrbService>(); } }
    }
 }
