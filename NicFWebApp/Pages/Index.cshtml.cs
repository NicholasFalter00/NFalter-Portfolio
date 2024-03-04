using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NicFWebApp.Pages.Shared.Classes;
using System.Reflection;

namespace NicFWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Experience Experience { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var position = new Position
            {
                JobTitle = "Software Engineer",
                Company = "ResourceData, Inc.",
                Description = "Did project work for various companies contracting Resource Data.",
                Projects = new List<Project>
                {
                    new Project
                    {
                        Title = "Pacific States Marine Fisheries Commission",
                        Description = "Implemented new API based data import process for data warehousing using PL/SQL, added a metadata check to verify the validity of loaded data, and rollback if needed, added new fields, and transformed the data using views and merging to meet business requirements. Created API endpoints for use with new commercial fishing app. API endpoints managed user account creation, email verification, password and username management, updating account properties, and submitting and reading vessel and fishing records.",
                    },
                    new Project 
                    {
                        Title = "CUI Devices",
                        Description = "Created a new application within FreeAgent CRM to track online purchases, including automatic association/creation of user and purchase information, and setting follow up reminders. Implemented using JavaScript.",
                    },
                    new Project
                    {
                        Title = "Washington Department of Agriculture",
                        Description = "Led client testing, and meetings collecting feedback on application. Performed application testing, reviewing developer changes, and providing direction for future development.",
                    },
                    new Project
                    {
                        Title = "Intranet",
                        Description = "Between projects developed feature improvements and bug fixes for internal Resource Data intranet toolsets using .NET Core MVC, ASP.NET, and SSMS.",
                    },
                }
            };
            Experience = new Experience
            {
                Positions = new List<Position>(),
            };
            Experience!.Positions!.Add(position);
        }
    }
}
