﻿namespace BlazorScrumApp.Models
{
	public class ScrumTask
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public int BoardID { get; set; }
		public int StateID { get; set; }
		public int AssigneeID { get; set; }
		public int ReporterID { get; set; }

		public Board? Board { get; set; }
		public State? State { get; set; }
		public User? Assignee { get; set; }
		public User? Reporter { get; set; }
	}
}
