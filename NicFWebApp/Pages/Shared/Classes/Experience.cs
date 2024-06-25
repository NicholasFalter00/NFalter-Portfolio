using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NicFWebApp.Pages.Shared.Classes
{
    public class Experience
    {
        [Key]
        public int id { get; set; }
        [DisplayName("Job Title")]
        public string? JobTitle { get; set; }
        public string? Company { get; set; }
        [DisplayName("Start Date")]
        public required string StartDate { get; set; }
        [DisplayName("End Date")]
        public required string EndDate { get; set; }
        public string? Description { get; set; }
        public List<Task> Tasks { get; set; } = [];
        public required string ExperienceType { get; set; }
        public int Order { get; set; }
    }
}
