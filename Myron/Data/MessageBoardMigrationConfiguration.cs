﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Myron.Data {
	public class MessageBoardMigrationConfiguration : DbMigrationsConfiguration<MessageBoardContext> {
		public MessageBoardMigrationConfiguration() {
			this.AutomaticMigrationDataLossAllowed = true;
			this.AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(MessageBoardContext context) {
			base.Seed(context);
#if DEBUG
			if (context.Topics.Count() == 0) {
				var topic = new Topic {
					Title = "I love MVC",
					Created = DateTime.Now,
					Body = "I love MVC bla bla bla",
					Replies = new List<Reply> {
						new Reply {
							Body = "Repl1",
							Created = DateTime.Now
						},
						new Reply {
							Body = "Repl2",
							Created = DateTime.Now
						},
						new Reply {
							Body = "Repl3",
							Created = DateTime.Now
						}
					}
				};

				context.Topics.Add(topic);

				var anotherTopic = new Topic {
					Title = "I love MVC",
					Created = DateTime.Now,
					Body = "I love MVC bla bla bla"
				};

				context.Topics.Add(anotherTopic);

				try {
					context.SaveChanges();
				} catch (Exception e) {
					var msg = e.Message;
				}
			}
#endif
		}
	}
}