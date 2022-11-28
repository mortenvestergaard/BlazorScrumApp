using BlazorScrumApp.Models;
using System.Net.Http.Json;

namespace BlazorScrumApp.Services
{
	public class ScrumboardService :IScrumboardService
	{
		private static HttpClient _client;

		public ScrumboardService(HttpClient client)
		{
			_client = client;
		}

		public async Task<List<Models.Task>> GetTasks()
		{
			var response = await _client.GetFromJsonAsync<List<Models.Task>>(_client.BaseAddress + "Task/GetTasks");
			return response;
		}

		public async Task<List<State>> GetStates()
		{
			var response = await _client.GetFromJsonAsync<List<State>>(_client.BaseAddress + "State/GetStates");
			return response;
		}

		public async Task<List<User>> GetUsers()
		{
			var response = await _client.GetFromJsonAsync<List<User>>(_client.BaseAddress + "User/GetUsers");
			return response;
		}

		public Task<State> CreateState()
		{
			throw new NotImplementedException();
		}

		public Task<Models.Task> CreateTask()
		{
			throw new NotImplementedException();
		}

		public Task<Models.Task> UpdateTask()
		{
			throw new NotImplementedException();
		}
	}
}
