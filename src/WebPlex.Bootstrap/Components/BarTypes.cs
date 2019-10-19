namespace WebPlex.Bootstrap.Components {
	using WebPlex.Bootstrap.Core;

	public enum BarTypes : byte {
		[Value("")]
		Inherits = 0,

		[Value("info")]
		Info,

		[Value("success")]
		Success,

		[Value("warning")]
		Warning,

		[Value("danger")]
		Danger
	}
}