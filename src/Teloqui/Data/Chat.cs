﻿using Newtonsoft.Json;

namespace Teloqui.Data {

	[JsonObject]
	public class Chat {
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("type")]
		public ChatType Type { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }
	}
}