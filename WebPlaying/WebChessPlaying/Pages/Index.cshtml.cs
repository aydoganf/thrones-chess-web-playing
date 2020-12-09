using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebChessPlaying.Configuration;

namespace WebChessPlaying.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAppConfiguration _appConfiguration;

        public IndexModel(ILogger<IndexModel> logger, IAppConfiguration appConfiguration)
        {
            _logger = logger;
            _appConfiguration = appConfiguration;
        }

        public void OnGet()
        {
            ViewData["SocketUrl"] = _appConfiguration.SocketUrl;
            ViewData["APIBaseUrl"] = _appConfiguration.APIBaseUrl;
        }
    }
}
