using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Myron.Data;

namespace Myron.Controllers {

	public class TopicsController : ApiController {

		private IMessageBoardRepository _repo;

		public TopicsController(IMessageBoardRepository repo) {
			_repo = repo;
		}

		public IEnumerable<Topic> Get() {
			var topics = _repo.GeTopics()
				.OrderByDescending(t => t.Created)
				.Take(25)
				.ToList();
			return topics;
		}
	}
}
