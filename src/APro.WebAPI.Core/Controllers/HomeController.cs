using System;
using Microsoft.AspNetCore.Mvc;

namespace APro.WebAPI.Core.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Ping(string name)
            => new ObjectResult($"Hello, {name}! Server's time: {DateTime.Now}");
    }
}