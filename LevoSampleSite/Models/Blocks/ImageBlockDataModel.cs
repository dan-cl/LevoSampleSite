using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;


namespace LevoSampleSite.Models.Blocks
{
    [ContentType(DisplayName = "ImageBlock", GUID = "4cd8e178-d93f-4c45-9070-e2bf6202a0b3", Description = "")]
    public class ImageBlockDataModel : BlockData
    {
       [Required]
       [Display(
           Name = "Image",
           Description = "Select an Image",
           Order = 100,
           GroupName = SystemTabNames.Content)]
       public virtual Url ImageUrl { get; set; }

       [Display(
           Name = "Alt text",
           Description = "Alt text for the image",
           Order = 200,
           GroupName = SystemTabNames.Content)]
       public virtual string AltText { get; set; }
    }
}