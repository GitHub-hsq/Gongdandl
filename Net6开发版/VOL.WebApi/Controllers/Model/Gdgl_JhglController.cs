/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹Gdgl_JhglController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.Model.IServices;
namespace VOL.Model.Controllers
{
    [Route("api/Gdgl_Jhgl")]
    [PermissionTable(Name = "Gdgl_Jhgl")]
    public partial class Gdgl_JhglController : ApiBaseController<IGdgl_JhglService>
    {
        public Gdgl_JhglController(IGdgl_JhglService service)
        : base(service)
        {
        }
    }
}

