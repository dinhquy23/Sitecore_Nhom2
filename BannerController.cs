using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;
using MockProject.Foundation.Mvc.Controllers;
using MockProject.Feature.Sample.Models.TemplateModels;

namespace MockProject.Feature.Sample.Controller
{
    public class BannerController : BaseController
    {
        public BannerController(IMvcContext mvcContext) : base(mvcContext)
        {
        }

        public ActionResult GetBanner()
        {
            var model = MvcContext.GetDataSourceItem<BannerModel>();
            return View("~/Views/MockProject/Main/Main.cshtml", model);
        }
    }
}