using System;
using System.Text.Json;
using SwapiAPIUI.Models;

namespace SwapiAPIUI.Data
{
	public class SwapiService
	{
		private readonly string swapiUrl = "https://swapi.dev/api/";
		private readonly IHttpClientFactory _httpClientFactory;

		public SwapiService(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<SwapiModel>? GetCharactersAsync()
		{
			var _client = _httpClientFactory.CreateClient();
			var response = await _client.GetAsync($"{ swapiUrl }people");

			SwapiModel? resp;

			var options = new JsonSerializerOptions
			{
				PropertyNameCaseInsensitive = true
			}; 

			string responseText = await response.Content.ReadAsStringAsync();
			resp = JsonSerializer.Deserialize<SwapiModel>(responseText, options);

			return resp;

		}
	}
}

