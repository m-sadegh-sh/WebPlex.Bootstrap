namespace WebPlex.Bootstrap.Builders {
	using WebPlex.Bootstrap.Components;

	public sealed class AlertBuilder : ComponentBuilderBase<AlertComponent, AlertBuilder> {
		public AlertBuilder Type(AlertTypes value) {
			Component.Type = value;

			return this;
		}

		public AlertBuilder Blocked(bool value) {
			Component.Blocked = value;

			return this;
		}

		public AlertBuilder RenderCloseButton(bool value) {
			Component.RenderCloseButton = value;

			return this;
		}

		public AlertBuilder CloseButtonText(string value) {
			Component.CloseButtonText = value;

			return this;
		}

		public AlertBuilder Title(string value) {
			Component.Title = value;

			return this;
		}

		public AlertBuilder Message(string value) {
			Component.Message = value;

			return this;
		}
	}
}