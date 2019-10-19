namespace WebPlex.Bootstrap.Renderers {
	public interface IRenderer<in TRenderingData> {
		RenderHelper Render(TRenderingData renderingData);
	}
}