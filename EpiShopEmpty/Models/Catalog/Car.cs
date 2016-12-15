using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;

namespace EpiShopEmpty.Models.Catalog
{
    [CatalogContentType(GUID = "ca3244ef-8acc-4a34-a29a-713d47891a4a", MetaClassName ="Car")]
    public class Car : NodeContent
    {
         
    }
}