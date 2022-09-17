﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace School.WebApplication.Areas.TeacherUser.Controllers
{
    [Authorize(Roles="Teacher")]
    [Area("TeacherUsers")]
    public class TeacherCPController : Controller
    {
        public IActionResult CPanel()
        {
            return View();
        }
    }
}
