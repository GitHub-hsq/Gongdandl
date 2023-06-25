/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Xmugl_XmulbService与IXmugl_XmulbService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Xmugl_XmulbService : ServiceBase<Xmugl_Xmulb, IXmugl_XmulbRepository>
    , IXmugl_XmulbService, IDependency
    {
    public Xmugl_XmulbService(IXmugl_XmulbRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IXmugl_XmulbService Instance
    {
      get { return AutofacContainerModule.GetService<IXmugl_XmulbService>(); } }
    }
 }
