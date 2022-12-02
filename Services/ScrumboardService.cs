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

		public async Task<List<Models.ScrumTask>> GetTasks()
		{
			var tasks = await _client.GetFromJsonAsync<List<Models.ScrumTask>>("https://7541-93-176-82-57.eu.ngrok.io/api/Task/GetTasks");
			return tasks;
		}

		public async Task<List<State>> GetStates()
		{
			var states = await _client.GetFromJsonAsync<List<State>>("https://7541-93-176-82-57.eu.ngrok.io/api/State/GetStates");
			return states;
		}

		public async Task<List<User>> GetUsers()
		{
			var users = await _client.GetFromJsonAsync<List<User>>("https://7541-93-176-82-57.eu.ngrok.io/api/User/GetUsers");
			return users;
		}

		public async Task<State> CreateState(State newState)
		{
			var returnedState = await _client.PostAsJsonAsync<State>("https://7541-93-176-82-57.eu.ngrok.io/api/State/CreateState", newState);
			var data = await returnedState.Content.ReadFromJsonAsync<State>();
			return data;
		}

		public async Task<ScrumTask> CreateTask(ScrumTask newTask)
		{
			var returnedTask = await _client.PostAsJsonAsync<ScrumTask>("https://7541-93-176-82-57.eu.ngrok.io/api/Task/CreateTask", newTask);
			var data = await returnedTask.Content.ReadFromJsonAsync<ScrumTask>();
			return data;
		}

		public async Task<ScrumTask> UpdateTaskState(ScrumTask taskToUpdate)
		{
			var updatedTask = await _client.PutAsJsonAsync<ScrumTask>("https://7541-93-176-82-57.eu.ngrok.io/api/Task/UpdateTaskState", taskToUpdate);
			var data = await updatedTask.Content.ReadFromJsonAsync<ScrumTask>();
			return data;
		}

		public async Task<ScrumTask> UpdateTask(ScrumTask taskToUpdate)
		{
			var updatedTask = await _client.PutAsJsonAsync<ScrumTask>("https://7541-93-176-82-57.eu.ngrok.io/api/Task/UpdateTask", taskToUpdate);
			var data = await updatedTask.Content.ReadFromJsonAsync<ScrumTask>();
			return data;
		}

        public async Task<HttpResponseMessage> DeleteTask(ScrumTask task)
        {
			var response = await _client.PostAsJsonAsync("https://7541-93-176-82-57.eu.ngrok.io/api/Task/DeleteTask", task);
            return response;
        }

		public async Task<HttpResponseMessage> DeleteState(State state)
		{
			var response = await _client.PostAsJsonAsync("https://7541-93-176-82-57.eu.ngrok.io/api/State/DeleteState", state);
			return response;
		}

        public async Task<HttpResponseMessage> SendEmailOnTaskCreated(User user)
        {
			var response = await _client.PostAsJsonAsync("https://7541-93-176-82-57.eu.ngrok.io/api/User/SendEmail", user);
			return response;
        }
    }
}
