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
    public class ImageBlockController : BlockController<ImageBlockDataModel>
    {
        public override ActionResult Index(ImageBlockDataModel currentBlock)
        {
            return PartialView("ImageBlock" , new ImageBlockViewModel(currentBlock));
        }
    }
}
