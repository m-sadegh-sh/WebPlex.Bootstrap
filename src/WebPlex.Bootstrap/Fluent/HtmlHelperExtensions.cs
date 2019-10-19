namespace WebPlex.Bootstrap.Fluent {
	using System.Web.Mvc;

	public static class HtmlHelperExtensions {
		public static ComponentFactory Bootstrap(this HtmlHelper htmlHelper) {
			return new ComponentFactory();
		}
	}
}