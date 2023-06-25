/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Jczl_BfglController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Jczl_Bfgl")]
    [PermissionTable(Name = "Jczl_Bfgl")]
    public partial class Jczl_BfglController : ApiBaseController<IJczl_BfglService>
    {
        public Jczl_BfglController(IJczl_BfglService service)
        : base(service)
        {
        }
    }
}

