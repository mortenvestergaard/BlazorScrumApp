namespace BlazorScrumApp.Models
{
	public class State
	{
		public int StateID { get; set; }
		public string Name { get; set; }
        public bool NewTaskOpen { get; set; }
        public string NewTaskName { get; set; }
    }
}
