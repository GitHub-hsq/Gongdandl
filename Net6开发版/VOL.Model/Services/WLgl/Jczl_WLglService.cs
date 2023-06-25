/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Jczl_WLglService与IJczl_WLglService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Jczl_WLglService : ServiceBase<Jczl_WLgl, IJczl_WLglRepository>
    , IJczl_WLglService, IDependency
    {
    public Jczl_WLglService(IJczl_WLglRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IJczl_WLglService Instance
    {
      get { return AutofacContainerModule.GetService<IJczl_WLglService>(); } }
    }
 }
