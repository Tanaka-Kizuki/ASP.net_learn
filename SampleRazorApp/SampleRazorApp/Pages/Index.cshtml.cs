using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message = "no messege";

        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [BindProperty(SupportsGet = true)]
        public int Num { get; set; }

        public void OnGet()
        {
            Message = "Please Write";
        }

        public void OnPost(string Name,string Password,string Mail,string Tel)
        {
            Message = "name:" + Name + "Password" + Password + "Mail" + Mail + "Tel" + Tel;
        }
    }
}
