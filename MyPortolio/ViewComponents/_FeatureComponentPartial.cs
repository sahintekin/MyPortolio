using Microsoft.AspNetCore.Mvc;

namespace MyPortolio.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
