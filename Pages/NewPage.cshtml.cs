using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Lab10.Pages
{
    public class NewPageModel : PageModel
    {
        private readonly ILogger _log;
        public NewPageModel(ILogger<IndexModel> log)
        {
            _log = log;
        }
        public void OnPost()
        {
            _log.LogInformation("OnPost() Called");
        }
        public void OnGet()
        {

        }
    }
}