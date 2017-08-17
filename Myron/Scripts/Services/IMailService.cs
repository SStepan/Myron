namespace Myron.Services {
	public interface IMailService {
		bool SendEmail(string from, string to, string subject, string body);
	}
}