using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiShopEmpty.Models.Media
{
    [ContentType(DisplayName = "DefaultMedia", GUID = "3f0ce2b7-2c24-48cd-b2cf-fd089838e628", Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class DefaultMedia : MediaData
    {
        /*
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Description { get; set; }
         */
    }
}