using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevoSampleSite.Models.Pages
{
    public class BasePageViewModel
    {
        
        public BasePageViewModel(BasePageDataModel currentPage)
        {
            this.CurrentPage = currentPage;
        }

        public BasePageDataModel CurrentPage { get;  }
    }
}