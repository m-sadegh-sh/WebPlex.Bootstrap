namespace WebPlex.Bootstrap.Core {
	public static class StringExtensions {
		public static string NotNullOr(this string value,
		                               string fallback) {
			return value ?? fallback;
		}

		public static string FormatWith(this string format,
		                                params object[] values) {
			return string.Format(format,
			                     values);
		}
	}
}