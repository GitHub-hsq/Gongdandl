/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下Ccgl_WLckuService与ICcgl_WLckuService中编写
 */
using VOL.Model.IRepositories;
using VOL.Model.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.Model.Services
{
    public partial class Ccgl_WLckuService : ServiceBase<Ccgl_WLcku, ICcgl_WLckuRepository>
    , ICcgl_WLckuService, IDependency
    {
    public Ccgl_WLckuService(ICcgl_WLckuRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICcgl_WLckuService Instance
    {
      get { return AutofacContainerModule.GetService<ICcgl_WLckuService>(); } }
    }
 }
