/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Bbzx_RcjbbController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Bbzx_Rcjbb")]
    [PermissionTable(Name = "Bbzx_Rcjbb")]
    public partial class Bbzx_RcjbbController : ApiBaseController<IBbzx_RcjbbService>
    {
        public Bbzx_RcjbbController(IBbzx_RcjbbService service)
        : base(service)
        {
        }
    }
}

