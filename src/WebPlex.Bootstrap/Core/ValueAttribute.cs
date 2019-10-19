namespace WebPlex.Bootstrap.Core {
	using System;

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
	public sealed class ValueAttribute : Attribute {
		public ValueAttribute(string value) {
			Value = value;
		}

		public string Value { get; set; }
	}
}