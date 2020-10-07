using Microsoft.AspNetCore.Components.Rendering;
using ComponentLayer.Pagination.Data;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public interface IPageRendererFactory
    {
        void Render(PageType pageType, RenderTreeBuilder builder, PageParams pageParams);
    }
}
