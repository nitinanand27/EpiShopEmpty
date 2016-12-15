using EPiServer.Core;
using EpiShopEmpty.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiShopEmpty.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            //Section = IContentExtensions.GetSection(currentPage.ContentLink);
        }

        public T CurrentPage { get; set; }
        public IContent Section { get; set; }
    }

    
}