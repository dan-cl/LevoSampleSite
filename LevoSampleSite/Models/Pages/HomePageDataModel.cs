using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.HtmlParsing;
using EPiServer.SpecializedProperties;
using LevoSampleSite.Models.Pages;

namespace LevoSampleSite.Models.Pages
{
    [ContentType(DisplayName = "HomePageDataModel", GUID = "c78d736b-3854-48ff-ae1f-c148c6de5fa7", Description = "")]
    public class HomePageDataModel : BasePageDataModel
    {
        [Display(
            Name = "Blocks",
            Description = "Content Area for Blocks",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ContentArea BlocksArea { get; set; }
    }
}