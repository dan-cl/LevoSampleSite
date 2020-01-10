using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using LevoSampleSite.Constants;
using System.ComponentModel.DataAnnotations;

namespace LevoSampleSite.Models.Pages
{
    [ContentType(DisplayName = "BasePageDataModel", GUID = "e9c7e5fb-a449-4587-b123-f61def4aca97", Description = "")]
    public abstract class BasePageDataModel : PageData
    {
        [Required]
        [Display(Name = "Page Title",
            Description = "",
            Order = 100,
            GroupName = TabNameConstants.METADATA)]
        public virtual string PageTitle { get; set; }

        [Required]
        [Display(Name = "Page Description",
            Description = "Provide a summary of the page for search results, max 155 characters",
            Order = 110,
            GroupName = TabNameConstants.METADATA)]
        public virtual string PageDescription { get; set; }
    }
}