using EPiServer.Web.Mvc;
using LevoSampleSite.Models.Pages;
using System.Web.Mvc;

namespace LevoSampleSite.Controllers.PageController
{
    [ContentOutputCache]
    public class HomePageController : PageController<HomePageDataModel>
    {
        public ActionResult Index(HomePageDataModel currentPage)
        {
            return View("HomePage", new HomePageViewModel(currentPage));
        }
    }
}