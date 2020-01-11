using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LevoSampleSite.Models.Blocks;

namespace LevoSampleSite.Helpers.HtmlHelpers
{
    public static class ImageHelper
    {
        public static MvcHtmlString Image(this HtmlHelper html, ImageBlockViewModel model)
        {
            var builder = new TagBuilder("img");
            builder.MergeAttribute("src", model.ImageUrl.ToString());
            builder.MergeAttribute("alt", model.AltText);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}