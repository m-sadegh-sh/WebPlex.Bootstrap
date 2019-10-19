namespace WebPlex.Bootstrap.Renderers {
	using System.Web.Mvc;

	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class ProgressRenderer : RendererBase<ProgressRenderingData> {
		public override RenderHelper Render(ProgressRenderingData renderingData) {
			var helper = new RenderHelper("div",
			                              TagRenderMode.Normal);

			helper.MergeAttributes(renderingData.Attributes);

			helper.MergeAttributes(Replace,
			                       new {
					                       @class = "progress"
			                       });

			helper.MergeAttributesConditionally(!string.IsNullOrEmpty(renderingData.Type),
			                                    Concat,
			                                    new {
					                                    @class = "progress-{0}".FormatWith(renderingData.Type)
			                                    });

			helper.MergeAttributesConditionally(renderingData.Striped,
			                                    Concat,
			                                    new {
					                                    @class = "progress-striped"
			                                    });

			helper.MergeAttributesConditionally(renderingData.Active,
			                                    Concat,
			                                    new {
					                                    @class = "active"
			                                    });

			return helper;
		}
	}
}