using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Myron.Models;
using Myron.Services;

namespace Myron.Controllers {
	public class HomeController : Controller {
		private IMailService _mail;

		public HomeController(IMailService mail) {
			_mail = mail;
		}

		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}

		[HttpPost]
		public ActionResult Contact(ContactModel model) {
			var msg = $"Comment from: {model.Name} \nEmail: {model.Email}\nWebsite: {model.Website}\nComment: {model.Comment}"; 

			if (_mail.SendEmail("myron@gmail.com", model.Email, "Myron's blog", msg)) {
				ViewBag.MailSent = true;
			}

			return View();
		}

		[HttpPost]
		public ActionResult MyMessages() {
			return View();
		}
	}
}