/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Xmugl_XmubService与IXmugl_XmubService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Xmugl_XmubService : ServiceBase<Xmugl_Xmub, IXmugl_XmubRepository>
    , IXmugl_XmubService, IDependency
    {
    public Xmugl_XmubService(IXmugl_XmubRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IXmugl_XmubService Instance
    {
      get { return AutofacContainerModule.GetService<IXmugl_XmubService>(); } }
    }
 }
