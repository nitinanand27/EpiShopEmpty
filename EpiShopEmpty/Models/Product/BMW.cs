using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;

namespace EpiShopEmpty.Models.Product
{
    [CatalogContentType(GUID = "c22a5831-b789-411d-b309-af5a4cb800d7", MetaClassName ="BMW")]
    public class BMW : ProductContent
    {
        
    }
}