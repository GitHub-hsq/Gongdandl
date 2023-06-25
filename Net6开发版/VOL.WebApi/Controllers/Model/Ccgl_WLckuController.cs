/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Ccgl_WLckuController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Ccgl_WLcku")]
    [PermissionTable(Name = "Ccgl_WLcku")]
    public partial class Ccgl_WLckuController : ApiBaseController<ICcgl_WLckuService>
    {
        public Ccgl_WLckuController(ICcgl_WLckuService service)
        : base(service)
        {
        }
    }
}

