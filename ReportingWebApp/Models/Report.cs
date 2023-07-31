namespace ReportingWebApp.Models
{
    public class Report : BaseEntity
    {
        public Category Category { get; set; }
        public TrainNumber? Number { get; set; }
        public string? Location { get; set; }
        public byte? InvolvedPeople { get; set; }
    }
}
