using System.ComponentModel.DataAnnotations;

namespace NicFWebApp.Pages.Shared.Classes
{
    public class Skill
    {
        [Key]
        public int id { get; set; }
        public required string SkillName { get; set; }
        public required SkillLevel SkillLevel { get; set; }
        public int? Order { get; set; }
    }
}
