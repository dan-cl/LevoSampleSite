using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer;

namespace LevoSampleSite.Models.Blocks
{
    public class ImageBlockViewModel
    {
        public Url ImageUrl { get; }
        public string AltText { get; }
        public ImageBlockViewModel(ImageBlockDataModel model)
        {
            ImageUrl = model.ImageUrl;
            AltText = model.AltText;
        }
    }
}