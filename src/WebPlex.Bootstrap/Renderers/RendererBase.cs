namespace WebPlex.Bootstrap.Renderers {
	public abstract class RendererBase<TRenderingData> : IRenderer<TRenderingData> {
		protected AttributeConflictResolvingStrategy Unchanged = AttributeConflictResolvingStrategy.Unchanged;

		protected AttributeConflictResolvingStrategy Replace = AttributeConflictResolvingStrategy.Replace;

		protected AttributeConflictResolvingStrategy Concat = AttributeConflictResolvingStrategy.Concat;

		public abstract RenderHelper Render(TRenderingData renderingData);
	}
}