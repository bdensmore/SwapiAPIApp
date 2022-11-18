using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using static NuGet.Client.ManagedCodeConventions;

namespace SwapiAPIUI.Models;

public class PersonModel
{

	public string Name { get; set; }
    public string Height { get; set; }
	public string Mass { get; set; }
	[JsonPropertyName("hair_color")]
    public string HairColor { get; set; }
    [JsonPropertyName("eye_color")]
    public string EyeColor { get; set; }
	public string BirthYear { get; set; }

}

