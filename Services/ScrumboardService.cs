using BlazorScrumApp.Models;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorScrumApp.Services
{
	public class ScrumboardService : IScrumboardService
	{
		private static HttpClient _client;

		public ScrumboardService(HttpClient client)
		{
			_client = client;
		}

		public async Task<List<Models.Task>> GetTasks()
		{
			var response = await _client.GetFromJsonAsync<List<Models.Task>>("https://localhost:7025/api/Task/GetTasks");
			return response;
		}

		public async Task<List<State>> GetStates()
		{
			var response = await _client.GetFromJsonAsync<List<State>>("https://localhost:7025/api/State/GetStates");
			return response;
		}

		public async Task<List<User>> GetUsers()
		{
			var response = await _client.GetFromJsonAsync<List<User>>("https://localhost:7025/api/User/GetUsers");
			return response;
		}

		public async System.Threading.Tasks.Task CreateState(State newState)
		{
			await _client.PostAsJsonAsync<State>("https://localhost:7025/api/State/CreateState", newState);
		}

		public Task<Models.Task> UpdateTask()
		{
			throw new NotImplementedException();
		}

		public Task<Models.Task> CreateTask()
		{
			throw new NotImplementedException();
		}
	}
}
