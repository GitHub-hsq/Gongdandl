/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Xmugl_XmubController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Xmugl_Xmub")]
    [PermissionTable(Name = "Xmugl_Xmub")]
    public partial class Xmugl_XmubController : ApiBaseController<IXmugl_XmubService>
    {
        public Xmugl_XmubController(IXmugl_XmubService service)
        : base(service)
        {
        }
    }
}

