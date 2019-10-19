namespace WebPlex.Bootstrap.Components {
	using System.Web.UI;

	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.Renderers;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class BarComponent : ComponentBase {
		public BarTypes Type { get; set; }
		public double Value { get; set; }

		protected override void WriteHtmlTo(HtmlTextWriter writer) {
			var helper = new BarRenderer().Render(new BarRenderingData {
					Attributes = Attributes,
					Type = Type.GetValue(),
					Value = Value
			});

			helper.WriteTo(writer);
		}
	}
}