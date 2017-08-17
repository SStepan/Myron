using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Myron.Data {
	public interface IMessageBoardRepository {
		IQueryable<Topic> GeTopics();
		IQueryable<Reply> GetRepliesByTopic(int topicId);
	}
}