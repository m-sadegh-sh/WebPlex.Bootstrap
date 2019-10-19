namespace WebPlex.Bootstrap.Components {
	using WebPlex.Bootstrap.Core;

	public enum AlertTypes : byte {
		[Value("")]
		Warning = 0,

		[Value("error")]
		Error,

		[Value("success")]
		Success,

		[Value("info")]
		Information
	}
}