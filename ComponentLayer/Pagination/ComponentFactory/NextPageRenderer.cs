using Microsoft.AspNetCore.Components.Rendering;

namespace ComponentLayer.Pagination.ComponentFactory
{
    public class NextPageRenderer : IPageRenderer
    {
        public void Render(PageParams pageParams, RenderTreeBuilder builder)
        {
            builder.OpenComponent(0, typeof(NextPage));
            builder.AddAttribute(1, "CurrentPage", pageParams.CurrentPage);
            builder.AddAttribute(2, "MaxPageValue", pageParams.MaxPageValue);
            builder.AddAttribute(3, "OnPageSelect", pageParams.OnPageSelect);
            builder.CloseComponent();
        }
    }
}
