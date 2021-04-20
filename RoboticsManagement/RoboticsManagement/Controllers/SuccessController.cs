﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoboticsManagement.Controllers
{
    public class SuccessController : Controller
    {
        [Authorize]
        public IActionResult Success()
        {
            return View();
        }
    }
}
