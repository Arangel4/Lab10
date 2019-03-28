using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab10.Pages
{
    public class NewPageModel : PageModel
    {
        [BindProperty]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "First Name")]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string LastName {get; set;}

        [BindProperty]
        [CreditCard]
        [Display(Name = "Credit Card Number")]
        [Required]
        public string CreditCardNumber {get; set;}

        private readonly ILogger _log;
        public NewPageModel(ILogger<NewPageModel> log)
        {
            _log = log;
        }

        public void OnGet()
        {
            Object b = null;
            if (b == null) _log.LogWarning("Object is null!");
            else b.ToString(); 
        }

        public void OnPost()
        {
            _log.LogWarning($"First Name: {FirstName} Last Name: {LastName}");
        }
    }
}