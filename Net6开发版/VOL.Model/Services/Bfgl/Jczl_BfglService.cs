/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Jczl_BfglService与IJczl_BfglService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Jczl_BfglService : ServiceBase<Jczl_Bfgl, IJczl_BfglRepository>
    , IJczl_BfglService, IDependency
    {
    public Jczl_BfglService(IJczl_BfglRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static IJczl_BfglService Instance
    {
      get { return AutofacContainerModule.GetService<IJczl_BfglService>(); } }
    }
 }
