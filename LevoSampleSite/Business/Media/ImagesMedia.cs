using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace LevoSampleSite.Business.Media
{
    [ContentType(DisplayName = "ImagesMedia", GUID = "bb5af69b-8c5b-4caf-8b75-9c438229f6d9", Description = "")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImagesMedia : ImageData
    {
        
    }
}