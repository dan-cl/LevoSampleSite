using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace LevoSampleSite.Models.Blocks
{
    [ContentType(DisplayName = "BasicTextBlock", GUID = "401145ae-e4f2-4db7-b8f5-2152b8ad74f6", Description = "")]
    public class BasicTextBlockDataModel : BlockData
    {
        [Required]
        [Display(
            Name = "Block Heading",
            Description = "Heading for the block",
            Order = 100,
            GroupName = SystemTabNames.Content)]
        public virtual string BlockHeading { get; set; }

        [Required]
        [Display(
            Name = "Block Text",
            Description = "Text for the block",
            Order = 200,
            GroupName = SystemTabNames.Content)]
        public virtual string BlockText { get; set; }
    }
}