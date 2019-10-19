namespace WebPlex.Bootstrap.RenderingDatas {
	using System.Collections.Generic;

	public abstract class RenderingDataBase {
		public IDictionary<string, object> Attributes { get; set; }
	}
}