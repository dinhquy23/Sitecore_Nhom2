using Glass.Mapper.Sc.Web.Mvc;
using System.Web.Mvc;
using MockProject.Foundation.Mvc.Controllers;
using MockProject.Feature.Sample.Models.TemplateModels;

namespace MockProject.Feature.Sample.Controller
{
    public class EmailSubscriptionController : BaseController
    {
        public EmailSubscriptionController(IMvcContext mvcContext) : base(mvcContext)
        {
        }

        public ActionResult GetHeader()
        {
            var model = MvcContext.GetDataSourceItem<EmailSubscriptionModel>();
            return View("~/Views/MockProject/Footer/Footer.cshtml", model);
        }
    }
}