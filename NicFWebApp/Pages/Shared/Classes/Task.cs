using System.ComponentModel.DataAnnotations;

namespace NicFWebApp.Pages.Shared.Classes
{
    public class Task
    {
        [Key]
        public int id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int ExperienceId { get; set; }
        public int Order { get; set; }
    }
}
