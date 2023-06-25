/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Bbzx_WLluliController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Bbzx_WLluli")]
    [PermissionTable(Name = "Bbzx_WLluli")]
    public partial class Bbzx_WLluliController : ApiBaseController<IBbzx_WLluliService>
    {
        public Bbzx_WLluliController(IBbzx_WLluliService service)
        : base(service)
        {
        }
    }
}

