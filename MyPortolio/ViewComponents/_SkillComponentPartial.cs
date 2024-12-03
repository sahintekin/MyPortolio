using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
