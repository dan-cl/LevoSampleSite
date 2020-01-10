using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace LevoSampleSite.Constants
{
    [GroupDefinitions]
    public static class TabNameConstants
    {
        [Display(Order = 100)] public const string METADATA = "MetaData";
    }
}