/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Gdgl_JhglService与IGdgl_JhglService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Gdgl_JhglService : ServiceBase<Gdgl_Jhgl, IGdgl_JhglRepository>
    , IGdgl_JhglService, IDependency
    {
    public Gdgl_JhglService(IGdgl_JhglRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IGdgl_JhglService Instance
    {
      get { return AutofacContainerModule.GetService<IGdgl_JhglService>(); } }
    }
 }
