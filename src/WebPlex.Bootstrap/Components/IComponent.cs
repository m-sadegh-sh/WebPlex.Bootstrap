namespace WebPlex.Bootstrap.Components {
	using System.Collections.Generic;
	using System.Web;

	public interface IComponent : IHtmlString {
		IDictionary<string, object> Attributes { get; }
	}
}