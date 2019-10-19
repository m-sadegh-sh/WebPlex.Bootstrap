namespace WebPlex.Bootstrap.Renderers {
	using System.Web.Mvc;

	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class AlertRenderer : RendererBase<AlertRenderingData> {
		public override RenderHelper Render(AlertRenderingData renderingData) {
			var helper = new RenderHelper("div",
			                              TagRenderMode.Normal);

			helper.MergeAttributes(renderingData.Attributes);

			helper.MergeAttributes(Replace,
			                       new {
					                       @class = "alert"
			                       });

			helper.MergeAttributesConditionally(!string.IsNullOrEmpty(renderingData.Type),
			                                    Concat,
			                                    new {
					                                    @class = "alert-{0}".FormatWith(renderingData.Type)
			                                    });

			helper.MergeAttributesConditionally(renderingData.Blocked,
			                                    Concat,
			                                    new {
					                                    @class = "alert-block"
			                                    });

			helper.AddInnerElementConditionally(renderingData.RenderCloseButton,
			                                    "a",
			                                    TagRenderMode.Normal,
			                                    innerHelper => {
				                                    innerHelper.MergeAttributes(Replace,
				                                                                new {
						                                                                href = "#",
						                                                                @class = "close",
						                                                                data_dismiss = "alert"
				                                                                });

				                                    innerHelper.SetInnerText(renderingData.CloseButtonText);
			                                    });

			helper.AddInnerElementConditionally(!string.IsNullOrEmpty(renderingData.Title),
			                                    "strong",
			                                    TagRenderMode.Normal,
			                                    innerHelper => innerHelper.SetInnerText(renderingData.Title));

			helper.AppendInnerHtmlConditionally(!string.IsNullOrEmpty(renderingData.Message),
			                                    renderingData.Message);

			return helper;
		}
	}
}