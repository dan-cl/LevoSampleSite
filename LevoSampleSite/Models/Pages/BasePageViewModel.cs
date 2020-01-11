using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LevoSampleSite.Models.Pages;

namespace LevoSampleSite.Models.Pages
{
    public class BasePageViewModel<T> where T : BasePageDataModel
    {
        
        public BasePageViewModel(T currentPage)
        {
            this.CurrentPage = currentPage;
        }

        public T CurrentPage { get;  }
    }
}