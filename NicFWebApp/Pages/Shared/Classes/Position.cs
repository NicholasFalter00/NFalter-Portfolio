namespace NicFWebApp.Pages.Shared.Classes
{
    public class Position
    {
        public string? JobTitle { get; set; }
        public string? Company { get; set; }
        public string? Description { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
