/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Ccgl_JxtzController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Ccgl_Jxtz")]
    [PermissionTable(Name = "Ccgl_Jxtz")]
    public partial class Ccgl_JxtzController : ApiBaseController<ICcgl_JxtzService>
    {
        public Ccgl_JxtzController(ICcgl_JxtzService service)
        : base(service)
        {
        }
    }
}

