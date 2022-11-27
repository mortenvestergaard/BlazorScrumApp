namespace BlazorScrumApp.Services
{
	public class ScrumboardService :IScrumboardService
	{
		private static HttpClient _client;

		public ScrumboardService(HttpClient client)
		{
			_client = client;
		}

		public async Task<IEnumerable<>> GetTasks()
		{

		}
	}
}
