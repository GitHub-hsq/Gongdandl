/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Ccgl_WLrkuController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Ccgl_WLrku")]
    [PermissionTable(Name = "Ccgl_WLrku")]
    public partial class Ccgl_WLrkuController : ApiBaseController<ICcgl_WLrkuService>
    {
        public Ccgl_WLrkuController(ICcgl_WLrkuService service)
        : base(service)
        {
        }
    }
}

