﻿using Newtonsoft.Json;

namespace Nest
{
	[JsonObject]
	public class ShardRefresh
	{
		[JsonProperty("listeners")]
		public long Listeners { get; internal set; }

		[JsonProperty("total")]
		public long Total { get; internal set; }

		[JsonProperty("total_time_in_millis")]
		public long TotalTimeInMilliseconds { get; internal set; }
	}
}
