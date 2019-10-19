namespace WebPlex.Bootstrap.Core {
	using System.Collections.Generic;
	using System.Web.Routing;

	public static class CastExtensions {
		public static IDictionary<string, object> ToDictionary(this object @object) {
			if (@object is RouteValueDictionary)
				return (RouteValueDictionary) @object;

			return new RouteValueDictionary(@object);
		}
	}
}