namespace WebPlex.Bootstrap.Components {
	using System.Web.UI;

	using WebPlex.Bootstrap.Core;
	using WebPlex.Bootstrap.Renderers;
	using WebPlex.Bootstrap.RenderingDatas;

	public sealed class AlertComponent : ComponentBase {
		public AlertTypes Type { get; set; }
		public bool Blocked { get; set; }
		public bool RenderCloseButton { get; set; }
		public string CloseButtonText { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }

		protected override void WriteHtmlTo(HtmlTextWriter writer) {
			var helper = new AlertRenderer().Render(new AlertRenderingData {
					Attributes = Attributes,
					Type = Type.GetValue(),
					Blocked = Blocked,
					RenderCloseButton = RenderCloseButton,
					CloseButtonText = CloseButtonText.NotNullOr("×"),
					Title = Title,
					Message = Message
			});

			helper.WriteTo(writer);
		}
	}
}