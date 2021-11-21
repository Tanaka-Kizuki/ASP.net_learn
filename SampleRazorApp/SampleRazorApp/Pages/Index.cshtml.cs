using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SampleRazorApp.Pages
{
    public class IndexModel : PageModel
    {

        public string Message { get; set; } = "This is sample message";
        private string[][] data = new string[][] {
            new string[]{"taro","taro@yamada"},
            new string[]{"hanako","hanako@flower"},
            new string[]{"sachiko","sachiko@happy"}
        };

        [BindProperty(SupportsGet = true)]
        public int id { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = "This is the added Message";
        }

        public string getData(int id)
        {
            string[] target = data[id];
            return "[名前：" + target[0] + "メール" + target[1] + "]";
        }
    }
}
