using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LevoSampleSite.Models.Blocks
{
    public class BasicTextBlockViewModel
    {
        public string BlockHeading;
        public string BlockText;

        public BasicTextBlockViewModel(BasicTextBlockDataModel model)
        {
            BlockHeading = model.BlockHeading;
            BlockText = model.BlockText;
        }
    }
}