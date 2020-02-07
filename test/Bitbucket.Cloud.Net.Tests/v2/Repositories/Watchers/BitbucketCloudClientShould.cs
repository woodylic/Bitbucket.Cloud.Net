﻿using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Bitbucket.Cloud.Net.Tests
{
	public partial class BitbucketCloudClientShould
	{
		[Theory]
		[InlineData("luve", "test")]
		public async Task GetRepositoryWatchersAsync(string workspaceId, string repositorySlug)
		{
			var result = await _client.GetRepositoryWatchersAsync(workspaceId, repositorySlug).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
