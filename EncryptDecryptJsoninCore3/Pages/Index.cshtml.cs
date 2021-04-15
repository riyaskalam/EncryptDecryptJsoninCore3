using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EncryptDecryptJsoninCore3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductionSettings secureAppSettings;

        public IndexModel(ILogger<IndexModel> logger, ProductionSettings secureAppSettings)
        {
            _logger = logger;
            this.secureAppSettings = secureAppSettings;
        }
        
        public void OnGet()
        {

        }
    }
}
