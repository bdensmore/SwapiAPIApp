using System;
using System.Text.Json.Serialization;

namespace SwapiAPIUI.Models
{
	public class SwapiModel
	{
		public int Count { get; set; }
		public string? previous { get; set; }
		public string Next { get; set; }
		[JsonPropertyName("results")]
		public List<PersonModel> Characters { get; set; }
	}
}

