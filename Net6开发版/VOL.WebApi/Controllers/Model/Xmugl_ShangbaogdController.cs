/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Xmugl_ShangbaogdController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Xmugl_Shangbaogd")]
    [PermissionTable(Name = "Xmugl_Shangbaogd")]
    public partial class Xmugl_ShangbaogdController : ApiBaseController<IXmugl_ShangbaogdService>
    {
        public Xmugl_ShangbaogdController(IXmugl_ShangbaogdService service)
        : base(service)
        {
        }
    }
}

