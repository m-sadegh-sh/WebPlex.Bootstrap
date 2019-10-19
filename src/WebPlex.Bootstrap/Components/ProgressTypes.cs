namespace WebPlex.Bootstrap.Components {
	using WebPlex.Bootstrap.Core;

	public enum ProgressTypes : byte {
		[Value("")]
		Default = 0,

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