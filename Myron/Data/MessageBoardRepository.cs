using System;
using System.Linq;

namespace Myron.Data {
	class MessageBoardRepository : IMessageBoardRepository {
		private MessageBoardContext _ctx;

		public MessageBoardRepository(MessageBoardContext ctx) {
			_ctx = ctx;
		}

		public IQueryable<Topic> GeTopics() {
			return _ctx.Topics;
		}

		public IQueryable<Reply> GetRepliesByTopic(int topicId) {
			return _ctx.Replies.Where(t => t.TopicId == topicId);
		}
	}
}