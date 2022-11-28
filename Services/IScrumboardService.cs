using BlazorScrumApp.Models;

namespace BlazorScrumApp.Services
{
	public interface IScrumboardService
	{
		Task<List<Models.Task>> GetTasks();
		Task<List<State>> GetStates();
		Task<List<User>> GetUsers();
		Task<Models.Task> CreateTask();
		Task<State> CreateState();
		Task<Models.Task> UpdateTask();

	}
}
