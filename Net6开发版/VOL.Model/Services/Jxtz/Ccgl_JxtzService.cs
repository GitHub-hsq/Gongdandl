/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Ccgl_JxtzService与ICcgl_JxtzService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Ccgl_JxtzService : ServiceBase<Ccgl_Jxtz, ICcgl_JxtzRepository>
    , ICcgl_JxtzService, IDependency
    {
    public Ccgl_JxtzService(ICcgl_JxtzRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICcgl_JxtzService Instance
    {
      get { return AutofacContainerModule.GetService<ICcgl_JxtzService>(); } }
    }
 }
