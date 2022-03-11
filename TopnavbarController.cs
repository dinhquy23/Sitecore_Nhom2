using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;
using MockProject.Foundation.Mvc.Controllers;
using MockProject.Feature.Sample.Models.TemplateModels;

namespace MockProject.Feature.Sample.Controller
{
    public class TopnavbarController : BaseController
    {
        public TopnavbarController(IMvcContext mvcContext) : base(mvcContext)
        {
        }

        public ActionResult GetNavigation()
        {
            var model = MvcContext.GetDataSourceItem<TopnavbarModel>();
            return View("~/Views/MockProject/Header/Navigation.cshtml", model);
        }
    }
}