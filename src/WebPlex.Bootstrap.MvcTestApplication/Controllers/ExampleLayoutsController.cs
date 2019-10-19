﻿namespace BootstrapMvcSample.Controllers {
	using System.Web.Mvc;

	public class ExampleLayoutsController : Controller {
		public ActionResult Starter() {
			return View();
		}

		public ActionResult Marketing() {
			return View();
		}

		public ActionResult Fluid() {
			return View();
		}

		public ActionResult Narrow() {
			return View();
		}

		public ActionResult SignIn() {
			return View();
		}

		public ActionResult StickyFooter() {
			return View("TBD");
		}

		public ActionResult Carousel() {
			return View("TBD");
		}
	}
}