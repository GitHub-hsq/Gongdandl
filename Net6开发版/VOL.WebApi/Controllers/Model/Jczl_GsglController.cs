/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Jczl_GsglController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Jczl_Gsgl")]
    [PermissionTable(Name = "Jczl_Gsgl")]
    public partial class Jczl_GsglController : ApiBaseController<IJczl_GsglService>
    {
        public Jczl_GsglController(IJczl_GsglService service)
        : base(service)
        {
        }
    }
}

