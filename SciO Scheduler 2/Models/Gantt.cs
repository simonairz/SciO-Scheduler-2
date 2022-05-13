namespace SciO_Scheduler_2.Models
{
    public class Gantt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)
        public int Id { get; set; }
        public string studentName { get; set; }

        public string studentLastName { get; set; }

        public string email { get; set; }
        public string studentEventsA { get; set; }
        public string studentEventsB { get; set; }
        public string studentEventsC { get; set; }
        public string studentEventsD { get; set; }
        public string studentEventsE { get; set; }
        public string studentEventsF { get; set; }

        public string studentEventsSelf { get; set; }

        public Gantt()
        {

        }
    }
}
