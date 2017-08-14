using System.Diagnostics;

namespace Myron.Services {
	public class MockMailService : IMailService {
		public bool SendEmail(string from, string to, string subject, string body)
		{
			Debug.WriteLine($"SendMail: {subject}");
			return true;
		}
	}
}