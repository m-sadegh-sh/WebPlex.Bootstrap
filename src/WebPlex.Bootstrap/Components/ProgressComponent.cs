namespace WebPlex.Bootstrap.Components {
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Web.UI;

	using WebPlex.Bootstrap.Builders;
	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.Renderers;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class ProgressComponent : ComponentBase {
		public ProgressComponent() {
			Bars = new Collection<BarBuilder>();
		}

		public ProgressTypes Type { get; set; }
		public bool Striped { get; set; }
		public bool Active { get; set; }
		public ICollection<BarBuilder> Bars { get; set; }

		protected override void WriteHtmlTo(HtmlTextWriter writer) {
			var helper = new ProgressRenderer().Render(new ProgressRenderingData {
					Attributes = Attributes,
					Type = Type.GetValue(),
					Striped = Striped,
					Active = Active
			});

			helper.WriteTo(writer);
		}
	}
}