namespace WebPlex.Bootstrap.Renderers {
	using System;
	using System.Diagnostics.Contracts;
	using System.Web.Mvc;
	using System.Web.UI;

	public sealed class RenderHelper {
		private readonly TagBuilder _tagBuilder;
		private readonly TagRenderMode _renderMode;

		public RenderHelper(string tagName,
		                    TagRenderMode renderMode) {
			Contract.Requires(!string.IsNullOrEmpty(tagName));

			_tagBuilder = new TagBuilder(tagName);
			_renderMode = renderMode;
		}

		public override string ToString() {
			return _tagBuilder.ToString(_renderMode);
		}

		public void WriteTo(HtmlTextWriter htmlTextWriter) {
			htmlTextWriter.Write(ToString());
		}

		public void AppendInnerHtml(string innerHtml) {
			AppendInnerHtmlConditionally(true,
			                             innerHtml);
		}

		public void AppendInnerHtmlConditionally(bool condition,
		                                         string innerHtml) {
			if (condition)
				_tagBuilder.InnerHtml += innerHtml;
		}

		public void SetInnerText(string innerText) {
			SetInnerTextConditionally(true,
			                          innerText);
		}

		public void SetInnerTextConditionally(bool condition,
		                                      string innerText) {
			if (condition)
				_tagBuilder.SetInnerText(innerText);
		}

		public void AddInnerElement(string tagName,
		                            TagRenderMode renderMode,
		                            Action<RenderHelper> innerElementBuilder) {
			AddInnerElementConditionally(true,
			                             tagName,
			                             renderMode,
			                             innerElementBuilder);
		}

		public void AddInnerElementConditionally(bool condition,
		                                         string tagName,
		                                         TagRenderMode renderMode,
		                                         Action<RenderHelper> innerElementBuilder) {
			Contract.Requires(!string.IsNullOrEmpty(tagName));

			if (condition) {
				var innerElement = new RenderHelper(tagName,
				                                    renderMode);

				innerElementBuilder(innerElement);

				_tagBuilder.InnerHtml += innerElement.ToString();
			}
		}

		public RenderHelper MergeAttributes(object attributes) {
			return MergeAttributes(AttributeConflictResolvingStrategy.Replace,
			                       attributes);
		}

		public RenderHelper MergeAttributesConditionally(bool condition,
		                                                 object attributes) {
			return MergeAttributesConditionally(condition,
			                                    AttributeConflictResolvingStrategy.Replace,
			                                    attributes);
		}

		public RenderHelper MergeAttributes(AttributeConflictResolvingStrategy resolvingStrategy,
		                                    object attributes) {
			_tagBuilder.MergeAttributes(resolvingStrategy,
			                            attributes);

			return this;
		}

		public RenderHelper MergeAttributesConditionally(bool condition,
		                                                 AttributeConflictResolvingStrategy resolvingStrategy,
		                                                 object attributes) {
			if (condition) {
				_tagBuilder.MergeAttributes(resolvingStrategy,
				                            attributes);
			}

			return this;
		}
	}
}