﻿using System.Web.Mvc;
using Dialogue.Models;

namespace Dialogue.Controllers
{
    public class CourseController : Controller
    {
        public ActionResult English(PositionVm data)
        {
            return View(data);
        }
        public ActionResult Spanish(PositionVm data)
        {
            return View(data);
        }

        public ActionResult German(PositionVm data)
        {
            return View(data);
        }

        public ActionResult French(PositionVm data)
        {
            return View(data);
        }

        public ActionResult Italian(PositionVm data)
        {
            return View(data);
        }

        public ActionResult Portuguese(PositionVm data)
        {
            return View(data);
        }
    }
}