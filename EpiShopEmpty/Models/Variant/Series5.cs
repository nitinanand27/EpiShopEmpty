using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;

namespace EpiShopEmpty.Models.Variant
{
    [CatalogContentType(GUID = "19adbc66-a18a-451c-ab34-c70482e772f7", MetaClassName ="5-Series")]
    public class Series5: VariationContent
    {

    }
}