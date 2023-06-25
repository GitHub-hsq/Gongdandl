/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Gdgl_PfgdService与IGdgl_PfgdService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Gdgl_PfgdService : ServiceBase<Gdgl_Pfgd, IGdgl_PfgdRepository>
    , IGdgl_PfgdService, IDependency
    {
    public Gdgl_PfgdService(IGdgl_PfgdRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IGdgl_PfgdService Instance
    {
      get { return AutofacContainerModule.GetService<IGdgl_PfgdService>(); } }
    }
 }
