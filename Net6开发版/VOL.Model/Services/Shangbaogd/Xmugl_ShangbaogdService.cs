/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Xmugl_ShangbaogdService与IXmugl_ShangbaogdService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Xmugl_ShangbaogdService : ServiceBase<Xmugl_Shangbaogd, IXmugl_ShangbaogdRepository>
    , IXmugl_ShangbaogdService, IDependency
    {
    public Xmugl_ShangbaogdService(IXmugl_ShangbaogdRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IXmugl_ShangbaogdService Instance
    {
      get { return AutofacContainerModule.GetService<IXmugl_ShangbaogdService>(); } }
    }
 }
