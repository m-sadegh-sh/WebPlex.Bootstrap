namespace WebPlex.Bootstrap.Renderers {
	using System;
	using System.Web.Mvc;

	using WebPlex.Bootstrap.Core;

	public static class TagBuilderExtensions {
		public static void MergeAttributes(this TagBuilder tagBuilder,
		                                   AttributeConflictResolvingStrategy resolvingStrategy,
		                                   object attributes) {
			var htmlAttributes = attributes.ToDictionary();

			foreach (var attribute in htmlAttributes) {
				if (!tagBuilder.Attributes.ContainsKey(attribute.Key)) {
					tagBuilder.MergeAttribute(attribute.Key,
					                          Convert.ToString(attribute.Value),
					                          true);
					continue;
				}

				switch (resolvingStrategy) {
					case AttributeConflictResolvingStrategy.Unchanged:
						break;

					case AttributeConflictResolvingStrategy.Replace:
						tagBuilder.MergeAttribute(attribute.Key,
						                          Convert.ToString(attribute.Value),
						                          true);
						break;

					case AttributeConflictResolvingStrategy.Concat:
						tagBuilder.MergeAttribute(attribute.Key,
						                          string.Format("{0} {1}",
						                                        tagBuilder.Attributes[attribute.Key],
						                                        Convert.ToString(attribute.Value)),
						                          true);
						break;

					default:
						throw new ArgumentOutOfRangeException("resolvingStrategy");
				}
			}
		}
	}
}