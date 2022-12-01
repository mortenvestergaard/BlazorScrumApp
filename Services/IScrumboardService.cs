using BlazorScrumApp.Models;
using System.Threading.Tasks;

namespace BlazorScrumApp.Services
{
    public interface IScrumboardService
    {
        //Tasks
        Task<List<ScrumTask>> GetTasks();
        Task<ScrumTask> CreateTask(ScrumTask task);
        Task<ScrumTask> UpdateTask(ScrumTask task);
        Task<ScrumTask> UpdateTaskState(ScrumTask task);
        Task<HttpResponseMessage> DeleteTask(ScrumTask task);
        //State
        Task<List<State>> GetStates();
        Task<State> CreateState(State state);
        Task<HttpResponseMessage> DeleteState(State state);
        //User
        Task<List<User>> GetUsers();

    }
}
