﻿using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
