using System;
using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public class SimplePageRenderer : IPageRenderer
    {
        public void Render(PageParams pageParams, RenderTreeBuilder builder)
        {
            builder.OpenComponent(0, typeof(SimplePage));
            builder.AddAttribute(1, "CurrentPage", pageParams.CurrentPage);
            builder.AddAttribute(2, "PageNumber", pageParams.PageNumber);
            builder.AddAttribute(3, "OnPageSelect", pageParams.OnPageSelect);
            builder.CloseComponent();
        }
    }
}
