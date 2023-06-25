/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Jczl_WLglController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Jczl_WLgl")]
    [PermissionTable(Name = "Jczl_WLgl")]
    public partial class Jczl_WLglController : ApiBaseController<IJczl_WLglService>
    {
        public Jczl_WLglController(IJczl_WLglService service)
        : base(service)
        {
        }
    }
}

