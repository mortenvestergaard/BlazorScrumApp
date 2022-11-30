using BlazorScrumApp.Models;
using System.Threading.Tasks;

namespace BlazorScrumApp.Services
{
	public interface IScrumboardService
	{
		Task<List<ScrumTask>> GetTasks();
		Task<List<State>> GetStates();
		Task<List<User>> GetUsers();
		Task<ScrumTask> CreateTask(ScrumTask task);
		Task<State> CreateState(State state);
		Task<ScrumTask> UpdateTask(ScrumTask task);

	}
}
