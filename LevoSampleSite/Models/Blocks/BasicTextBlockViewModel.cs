using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevoSampleSite.Models.Blocks
{
    public class BasicTextBlockViewModel
    {
        public string BlockHeading { get; }
        public string BlockText { get; }

        public BasicTextBlockViewModel(BasicTextBlockDataModel model)
        {
            BlockHeading = model.BlockHeading;
            BlockText = model.BlockText;
        }
    }
}