﻿using Microsoft.AspNetCore.Mvc;
using MyPortolio.DAL.Context;

namespace MyPortolio.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTittle=portfolioContext.Abouts.Select(x=>x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription=portfolioContext.Abouts.Select(x=>x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetails=portfolioContext.Abouts.Select(x=>x.Details).FirstOrDefault();
            return View();
        }
    }
}
