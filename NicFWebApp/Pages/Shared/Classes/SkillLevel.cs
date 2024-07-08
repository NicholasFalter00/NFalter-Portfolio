using System.ComponentModel.DataAnnotations;

namespace NicFWebApp.Pages.Shared.Classes
{
    public class SkillLevel
    {
        [Key]
        public int id { get; set; }
        public required string SkillLevelName { get; set; }
        public byte[] Graphic { get; set; }
    }
}
