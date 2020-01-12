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
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View("HomePage", new HomePageViewModel(currentPage));
        }
    }
}