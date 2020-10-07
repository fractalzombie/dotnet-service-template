using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components.Rendering;
using ComponentLayer.Pagination.Data;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public class PageRendererFactory : IPageRendererFactory
    {
        private readonly IDictionary<PageType, IPageRenderer> _pageTypeMapping =
            new Dictionary<PageType, IPageRenderer>
            {
                {PageType.Page, new SimplePageRenderer()},
                {PageType.Prev, new PrevPageRenderer()},
                {PageType.Next, new NextPageRenderer()},
                {PageType.Separator, new SeparatorPageRenderer()},
            };

        public void Render(PageType pageType, RenderTreeBuilder builder, PageParams pageParams)
        {
            if (!_pageTypeMapping.ContainsKey(pageType))
            {
                throw new Exception($"Type: {pageType} has no component mapping");
            }

            _pageTypeMapping[pageType].Render(pageParams, builder);
        }
    }
}
