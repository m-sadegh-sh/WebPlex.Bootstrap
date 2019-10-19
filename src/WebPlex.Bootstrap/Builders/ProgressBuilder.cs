namespace WebPlex.Bootstrap.Builders {
	using System;

	using WebPlex.Bootstrap.Components;

	public sealed class ProgressBuilder : ComponentBuilderBase<ProgressComponent, ProgressBuilder> {
		public ProgressBuilder Type(ProgressTypes value) {
			Component.Type = value;

			return this;
		}

		public ProgressBuilder Striped(bool value) {
			Component.Striped = value;

			return this;
		}

		public ProgressBuilder Active(bool value) {
			Component.Active = value;

			return this;
		}

		public ProgressBuilder Bars(params Action<BarBuilder>[] barBuilders) {
			foreach (var barBuilder in barBuilders) {
				var bar = new BarBuilder();
				barBuilder(bar);

				Component.Bars.Add(bar);
			}

			return this;
		}
	}
}