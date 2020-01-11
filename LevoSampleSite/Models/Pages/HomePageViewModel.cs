using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using LevoSampleSite.Models.Pages;

namespace LevoSampleSite.Models.Pages
{
    public class HomePageViewModel : BasePageViewModel<BasePageDataModel>
    {
        public ContentArea PageBlocks { get; }
        public HomePageViewModel(HomePageDataModel currentPage) : base (currentPage)
        {
            PageBlocks = currentPage.BlocksArea;
        }
    }
}