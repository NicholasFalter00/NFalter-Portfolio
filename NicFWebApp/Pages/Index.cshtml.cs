using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NicFWebApp.Pages.Shared.Classes;
using System.Reflection;

namespace NicFWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Experience> EmploymentHistory { get; set; } = new List<Experience>();

        public List<Experience> Projects { get; set; } = new List<Experience>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var resourceData = new Experience
            {
                JobTitle = "Software Engineer",
                Company = "Resource Data, Inc.",
                StartDate = new DateTime(2022, 6, 1),
                EndDate = DateTime.Now,
                Description = "Did project work for various companies contracting Resource Data.",
                Tasks = new List<Shared.Classes.Task>
                {
                    new Shared.Classes.Task
                    {
                        Title = "Pacific States Marine Fisheries Commission",
                        Description = "Implemented new API based data import process for data warehousing using PL/SQL, added a" +
                            " metadata check to verify the validity of loaded data, and rollback if needed, added new fields," +
                            " and transformed the data using views and merging to meet business requirements. " +
                            "Created API endpoints for use with new commercial fishing app. API endpoints managed user account creation, " +
                            "email verification, password and username management, updating account properties, and submitting" +
                            " and reading vessel and fishing records.",
                    },
                    new Shared.Classes.Task 
                    {
                        Title = "CUI Devices",
                        Description = "Created a new application within FreeAgent CRM to track online purchases," +
                            " including automatic association/creation of user and purchase information," +
                            " and setting follow up reminders. Implemented using JavaScript.",
                    },
                    new Shared.Classes.Task
                    {
                        Title = "Washington Department of Agriculture",
                        Description = "Led client testing, and meetings collecting feedback on application." +
                            " Performed application testing, reviewing developer changes, and providing direction for future development.",
                    },
                    new Shared.Classes.Task
                    {
                        Title = "Intranet",
                        Description = "Between projects developed feature improvements and bug fixes for internal Resource Data intranet toolsets using .NET Core MVC, ASP.NET, and SSMS.",
                    },
                }
            };

            var programmingTutor = new Experience
            {
                JobTitle = "Programming Tutor",
                Company = "Tutor.com, Inc.",
                StartDate = new DateTime(2023, 12, 1),
                EndDate = DateTime.Now,
                Description = "Working part time as a programming tutor, teaching C++, C#, Java, and Python.",
            };

            var tataConsultancy = new Experience
            {
                JobTitle = "Software Engineer",
                Company = "Tata Consultancy Services",
                StartDate = new DateTime(2021, 6, 1),
                EndDate = new DateTime(2022, 6, 1),
                Description = "On assignment at CVS Health. Used Scrum development lifecycle to design and execute tests to " +
                    "ensure programs are defect free. Tracked test cases and defects in Rally and used Control-M to " +
                    "execute batch programs. Worked closely with the development team to ensure comprehensive " +
                    "testing. Prepared demos of program functionality.",
            };

            EmploymentHistory!.Add(resourceData);
            EmploymentHistory.Add(programmingTutor);
            EmploymentHistory!.Add(tataConsultancy);

            var nas = new Experience
            {
                JobTitle = "Network Attached Storage Server",
                Company = "Hobby",
                StartDate = new DateTime(2023, 7, 1),
                EndDate = new DateTime(2023, 8, 1),
                Description = "Set up a NAS server. Configured TrueNAS operating system to allow LAN media storage, then " +
                    "setup ZeroTier VPN to enable remote access.",
            };

            var machineLearning = new Experience
            {
                JobTitle = "Machine Learning Threat Detection",
                Company = "Boeing & University",
                StartDate = new DateTime(2020, 9, 1),
                EndDate = new DateTime(2021, 6, 1),
                Description = "Worked with a team of 4 to simulate 6 different attacks on computer systems. Used Python to test 6 " +
                    "different machine learning algorithms, both supervised and unsupervised to classify the logs resulting from " +
                    "the attacks as either safe or unsafe, and then, if determined to be unsafe, the specific attack a log " +
                    "represented was then predicted. The  performance metrics of the different models were compared and the best " +
                    "performing model was selected. In the project personally implemented support vector machines algorithm, which " +
                    "classified with up to 95% accurancy, and was selected as the best model.",
            };

            var databaseDesign = new Experience
            {
                JobTitle = "Database System Design",
                Company = "University",
                StartDate = new DateTime(2021, 3, 1),
                EndDate = new DateTime(2021, 6, 1),
                Description = "Created a database for a theoretical dental office chain using MSSQL. Normalized database " +
                    "stored all relevant information about patients, employees, and offices. The database consisted of 17 " +
                    "interrelated tables. An interface was created in C# to insert and search for patients.",
            };

            var huffmanEncoding = new Experience
            {
                JobTitle = "Huffman Tree Encoding",
                Company = "University",
                StartDate = new DateTime(2020, 05, 1),
                EndDate = new DateTime(2020, 05, 31),
                Description = "Manually constructed a Huffman tree to encode a string to a more space efficient representation. " +
                    "The Huffman tree was constructed from a priority queue that was created from an array heap. All data " +
                    "structures used were manually implemented in Java.",
            };

            var processorDevelopment = new Experience
            {
                JobTitle = "Processor Development",
                Company = "University",
                StartDate = new DateTime(2020, 05, 1),
                EndDate = new DateTime(2020, 05, 31),
                Description = "Programmed a field-programmable gate array in SystemVerilog as a CPU. Processor executed basic " +
                    "mathematical operations. Personally managed control unit implementation, which read binary instructions, " +
                    "sent the operation to execute and the associated data to the logic unit, then proceeded to the next instruction.",
            };

            Projects!.Add(nas);
            Projects!.Add(machineLearning);
            Projects!.Add(databaseDesign);
            Projects!.Add(huffmanEncoding);
            Projects!.Add(processorDevelopment);
        }
    }
}
