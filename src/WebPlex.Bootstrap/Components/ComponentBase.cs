namespace WebPlex.Bootstrap.Components {
	using System.Collections.Generic;
	using System.IO;
	using System.Web.Routing;
	using System.Web.UI;

	public abstract class ComponentBase : IComponent {
		protected ComponentBase() {
			Attributes = new RouteValueDictionary();
		}

		public IDictionary<string, object> Attributes { get; private set; }

		public string ToHtmlString() {
			string result;

			using (var stringWriter = new StringWriter()) {
				WriteHtmlTo(new HtmlTextWriter(stringWriter));

				result = stringWriter.ToString();
			}

			return result;
		}

		protected abstract void WriteHtmlTo(HtmlTextWriter writer);
	}
}