using Syncfusion.Maui.Scheduler;
using System.Collections.ObjectModel;

namespace SmartSchedulerSample
{
	public class ViewModel
	{
		private ObservableCollection<SchedulerAppointment>? appointments;
		public ObservableCollection<SchedulerAppointment>? Appointments
		{
			get => appointments;
			set { appointments = value; }
		}

        private List<string> suggestedPrompts;
        public List<string> SuggestedPrompts
        {
            get => suggestedPrompts;
            set { suggestedPrompts = value; }
        }
		public ViewModel()
		{
			Appointments = new ObservableCollection<SchedulerAppointment>()
			{
                new SchedulerAppointment
                {
                    StartTime = DateTime.Today.AddHours(7),
                    EndTime = DateTime.Today.AddHours(8),
                    Subject = "Yoga Session",
                    Background = Colors.DeepPink
                },
                new SchedulerAppointment
                {
                    StartTime = DateTime.Today.AddHours(9),
                    EndTime = DateTime.Today.AddHours(10),
                    Subject = "Medical Checkup",
                    Background= Colors.Purple
                },
                new SchedulerAppointment
                {
                    StartTime = DateTime.Today.AddHours(12),
                    EndTime = DateTime.Today.AddHours(14),
                    Subject = "Client Meeting",
                    Background= Colors.OrangeRed
                },
                new SchedulerAppointment
                {
                    StartTime = DateTime.Today.AddHours(17),
                    EndTime = DateTime.Today.AddHours(18),
                    Subject = "Project Discussion",
                    Background = Colors.Blue
                },
                new SchedulerAppointment
                {
                    StartTime = DateTime.Today.AddHours(19),
                    EndTime = DateTime.Today.AddHours(20),
                    Subject = "Badminton Coaching",
                    Background = Colors.Green
                }
            };

            SuggestedPrompts = new List<string>
            {
                "Summarize today's appointments",
                "Find today's free timeslots",
                "Conflict detection"
            };
		}
	}
}