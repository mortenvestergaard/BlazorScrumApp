using BlazorScrumApp.Models;
using System.Threading.Tasks;

namespace BlazorScrumApp.Services
{
	public interface IScrumboardService
	{
		Task<List<Models.Task>> GetTasks();
		Task<List<State>> GetStates();
		Task<List<User>> GetUsers();
		Task<Models.Task> CreateTask();
		System.Threading.Tasks.Task CreateState(State state);
		Task<Models.Task> UpdateTask();

	}
}
