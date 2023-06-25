/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Bbzx_Sskc0Controller编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Bbzx_Sskc0")]
    [PermissionTable(Name = "Bbzx_Sskc0")]
    public partial class Bbzx_Sskc0Controller : ApiBaseController<IBbzx_Sskc0Service>
    {
        public Bbzx_Sskc0Controller(IBbzx_Sskc0Service service)
        : base(service)
        {
        }
    }
}

