using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiShopEmpty.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "a281f1b0-668c-469f-991c-3ceb1697636e", Description = "")]
    public class StartPage : SitePageData
    {
       
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }

    }
}