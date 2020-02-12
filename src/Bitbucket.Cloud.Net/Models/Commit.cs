﻿using System;
using System.Collections.Generic;

namespace Bitbucket.Cloud.Net.Models
{
	public class Commit : CommitInfo
	{
		public HasMessage Rendered { get; set; }
		public RepositoryInfo Repository { get; set; }
		public Author Author { get; set; }
		public Message Summary { get; set; }
		public IEnumerable<RefParent> Parents { get; set; }
		public DateTime Date { get; set; }
		public string Message { get; set; }
	}
}