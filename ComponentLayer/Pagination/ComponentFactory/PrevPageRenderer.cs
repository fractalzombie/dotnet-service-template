using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public class PrevPageRenderer : IPageRenderer
    {
        public void Render(PageParams pageParams, RenderTreeBuilder builder)
        {
            builder.OpenComponent(0, typeof(PrevPage));
            builder.AddAttribute(1, "CurrentPage", pageParams.CurrentPage);
            builder.AddAttribute(2, "MinPageValue", pageParams.MinPageValue);
            builder.AddAttribute(3, "OnPageSelect", pageParams.OnPageSelect);
            builder.CloseComponent();
        }
    }
}
