namespace WebPlex.Bootstrap.Builders {
	using WebPlex.Bootstrap.Components;

	public sealed class BarBuilder : ComponentBuilderBase<BarComponent, BarBuilder> {
		public BarBuilder Type(BarTypes value) {
			Component.Type = value;

			return this;
		}

		public BarBuilder Value(double value) {
			Component.Value = value;

			return this;
		}
	}
}