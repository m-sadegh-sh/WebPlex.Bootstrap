namespace WebPlex.Bootstrap.RenderingDatas {
	public sealed class AlertRenderingData : RenderingDataBase {
		public string Type { get; set; }
		public bool Blocked { get; set; }
		public bool RenderCloseButton { get; set; }
		public string CloseButtonText { get; set; }
		public string Title { get; set; }
		public string Message { get; set; }
	}
}