using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public class SeparatorPageRenderer : IPageRenderer
    {
        public void Render(PageParams pageParams, RenderTreeBuilder builder)
        {
            builder.OpenComponent(0, typeof(SeparatorPage));
            builder.CloseComponent();
        }
    }
}
