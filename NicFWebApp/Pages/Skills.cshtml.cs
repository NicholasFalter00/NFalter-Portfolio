using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NicFWebApp.Pages.Shared.Classes;

namespace NicFWebApp.Pages
{
    public class SkillModel : PageModel
    {
        private readonly ILogger<SkillModel> _logger;

        private readonly SqliteContext _context;

        public List<Skill> Skills { get; set; } = new List<Skill>();

        public SkillModel(ILogger<SkillModel> logger, SqliteContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async System.Threading.Tasks.Task OnGetAsync()
        {
            Skills = await _context.Skills.OrderBy(x => x.Order).ToListAsync();
            await _context.LookupSkillLevels.ToListAsync(); // populate skill levels
        }
    }

}
