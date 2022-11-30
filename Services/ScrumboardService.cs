﻿using BlazorScrumApp.Models;
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
			var tasks = await _client.GetFromJsonAsync<List<Models.ScrumTask>>("https://localhost:7025/api/Task/GetTasks");
			return tasks;
		}

		public async Task<List<State>> GetStates()
		{
			var states = await _client.GetFromJsonAsync<List<State>>("https://localhost:7025/api/State/GetStates");
			return states;
		}

		public async Task<List<User>> GetUsers()
		{
			var users = await _client.GetFromJsonAsync<List<User>>("https://localhost:7025/api/User/GetUsers");
			return users;
		}

		public async Task<State> CreateState(State newState)
		{
			var returnedState = await _client.PostAsJsonAsync<State>("https://localhost:7025/api/State/CreateState", newState);
			var data = await returnedState.Content.ReadFromJsonAsync<State>();
			return data;
		}

		public async Task<ScrumTask> CreateTask(ScrumTask newTask)
		{
			var returnedTask = await _client.PostAsJsonAsync<ScrumTask>("https://localhost:7025/api/Task/CreateTask", newTask);
			var data = await returnedTask.Content.ReadFromJsonAsync<ScrumTask>();
			return data;
		}

		public Task<ScrumTask> UpdateTask()
		{
			throw new NotImplementedException();
		}
	}
}