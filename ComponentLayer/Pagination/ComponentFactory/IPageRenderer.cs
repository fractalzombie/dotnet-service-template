using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public interface IPageRenderer
    {
        void Render(PageParams pageParams, RenderTreeBuilder builder);
    }
}
