// Index.cshtml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ResumeTemplater.Pages
{
    public class IndexModel : PageModel
    {
        public string FullName { get; set; }
        public string LinkedInUsername { get; set; }
        public int YearsOfExperience { get; set; }
        public List<string> Languages { get; set; }
        public void OnGet()
        {
            this.FullName = "Jaime Moreno";
            this.LinkedInUsername = "jaimemoreno";
            this.YearsOfExperience = 21;
            this.Languages = new List<string>();
            Languages.Add("Spanish");
            Languages.Add("English");
            Languages.Add("French");

        }
    }
}
