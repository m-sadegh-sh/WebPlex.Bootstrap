namespace WebPlex.Bootstrap.Builders {
	using System.Collections.Generic;
	using System.Web.Mvc;

	using WebPlex.Bootstrap.Components;

	public abstract class ComponentBuilderBase<TComponent, TComponentBuilder> : IComponentBuilder<TComponent, TComponentBuilder> where TComponent : class, IComponent, new()
	                                                                                                                             where TComponentBuilder : IComponentBuilder<TComponent, TComponentBuilder> {
		protected ComponentBuilderBase() {
			Component = new TComponent();
			Attributes = Component.Attributes;
		}

		protected TComponent Component { get; private set; }

		protected IDictionary<string, object> Attributes { get; private set; }

		public TComponentBuilder Id(string id) {
			AddOrReplaceAttribute("id",
			                      id);

			return (TComponentBuilder) (object) this;
		}

		protected void AddOrReplaceAttribute(string key,
		                                     object value) {
			if (Attributes.ContainsKey(key))
				Attributes[key] = value;
			else {
				Attributes.Add(key,
				               value);
			}
		}

		protected void AddOrAppendAttribute(string key,
		                                    object value) {
			if (Attributes.ContainsKey(key))
				Attributes[key] = Attributes[key] + " " + value;
			else {
				Attributes.Add(key,
				               value);
			}
		}

		public override string ToString() {
			return ToHtmlString();
		}

		public string ToHtmlString() {
			return MvcHtmlString.Create(Component.ToHtmlString()).
			                     ToHtmlString();
		}
	}
}