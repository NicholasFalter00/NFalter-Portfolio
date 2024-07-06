using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NicFWebApp.Pages.Shared.Classes;
using System.Reflection;

namespace NicFWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly SqliteContext _context;

        public List<Experience> EmploymentHistory { get; set; } = new List<Experience>();

        public List<Experience> Projects { get; set; } = new List<Experience>();

        public IndexModel(ILogger<IndexModel> logger, SqliteContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            var experiences = await _context.Experiences.ToListAsync();
            await _context.Tasks.OrderBy(x => x.Order).ToListAsync(); // populate tasks for experiences

            EmploymentHistory = experiences.Where(x => x.ExperienceType == "Employment").OrderBy(y => y.Order).ToList();
            Projects = experiences.Where(x => x.ExperienceType == "Project").OrderBy(y => y.Order).ToList();

            EmploymentHistory = FormatDate(EmploymentHistory);
            Projects = FormatDate(Projects);
        }

        private static List<Experience> FormatDate(List<Experience> experiences)
        {
            foreach (var experience in experiences)
            {
                experience.StartDate = @String.Format("{0:MM/yyyy}", DateTime.Parse(experience.StartDate));
                try
                {
                    experience.EndDate = @String.Format("{0:MM/yyyy}", DateTime.Parse(experience.EndDate));
                }
                catch
                {
                }
            }
            return experiences;
        }
    }
}
