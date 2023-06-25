/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Jczl_RyglController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Jczl_Rygl")]
    [PermissionTable(Name = "Jczl_Rygl")]
    public partial class Jczl_RyglController : ApiBaseController<IJczl_RyglService>
    {
        public Jczl_RyglController(IJczl_RyglService service)
        : base(service)
        {
        }
    }
}

