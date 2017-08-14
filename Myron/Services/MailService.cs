using System;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Myron.Services {
	public class MailService : IMailService {
		public bool SendEmail(string from, string to, string subject, string body) {
			try {
				var msg = new MailMessage(from, to, subject, body);

				var smtp = new SmtpClient();
				smtp.Send(msg);
			} catch (Exception e) {
				return false;
			}

			return true;
		}
	}
}