using ExpenseTracker.App.ViewModels.Shared;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.App.ViewComponents;

public class PageHeaderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke(PageHeaderViewModel model)
    {
        return View(model);
    }
}
