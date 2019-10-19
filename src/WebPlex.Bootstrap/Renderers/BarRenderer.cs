namespace WebPlex.Bootstrap.Renderers {
	using System.Web.Mvc;

	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class BarRenderer : RendererBase<BarRenderingData> {
		public override RenderHelper Render(BarRenderingData renderingData) {
			var helper = new RenderHelper("div",
			                              TagRenderMode.Normal);

			helper.MergeAttributes(renderingData.Attributes);

			helper.MergeAttributes(Replace,
			                       new {
					                       @class = "bar"
			                       });

			helper.MergeAttributesConditionally(!string.IsNullOrEmpty(renderingData.Type),
			                                    Concat,
			                                    new {
					                                    @class = "bar-{0}".FormatWith(renderingData.Type)
			                                    });

			helper.MergeAttributes(Concat,
			                       new {
					                       style = "width: {0}%".FormatWith(renderingData.Value)
			                       });

			return helper;
		}
	}
}