using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using LevoSampleSite.Models.Blocks;

namespace LevoSampleSite.Controllers.BlockController
{
    public class BasicTextBlockController : BlockController<BasicTextBlockDataModel>
    {
        public override ActionResult Index(BasicTextBlockDataModel currentBlock)
        {
            return PartialView("BasicTextBlock", new BasicTextBlockViewModel(currentBlock));
        }
    }
}
