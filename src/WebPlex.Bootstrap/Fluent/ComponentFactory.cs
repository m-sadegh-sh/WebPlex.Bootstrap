namespace WebPlex.Bootstrap.Fluent {
	using WebPlex.Bootstrap.Builders;

	public sealed class ComponentFactory {
		public AlertBuilder Alert() {
			return new AlertBuilder();
		}

		public ProgressBuilder Progress() {
			return new ProgressBuilder();
		}
	}
}