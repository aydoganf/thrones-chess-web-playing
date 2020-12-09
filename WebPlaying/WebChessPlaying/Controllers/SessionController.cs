using Microsoft.AspNetCore.Mvc;
using System;
using WebChessPlaying.Configuration;

namespace WebChessPlaying.Controllers
{
    public class SessionController : Controller
    {
        private readonly IAppConfiguration _appConfiguration;

        public SessionController(IAppConfiguration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }


        public IActionResult View(Guid id, [FromQuery(Name = "nickname")] string nickname)
        {
            ViewBag.SessionName = id.ToString();
            ViewBag.PlayerNickname = nickname.ToLower();
            ViewBag.SocketUrl = _appConfiguration.SocketUrl;
            ViewBag.APIBaseUrl = _appConfiguration.APIBaseUrl;
            return View();
        }
    }
}
