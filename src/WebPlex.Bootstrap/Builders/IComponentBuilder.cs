namespace WebPlex.Bootstrap.Builders {
	using System.Web;

	using WebPlex.Bootstrap.Components;

	public interface IComponentBuilder<out TComponent, out TComponentBuilder> : IHtmlString where TComponent : class, IComponent
	                                                                                        where TComponentBuilder : IComponentBuilder<TComponent, TComponentBuilder> {
		TComponentBuilder Id(string id);
	}
}