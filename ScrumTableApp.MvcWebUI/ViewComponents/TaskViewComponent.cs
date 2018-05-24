using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScrumTableApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumTableApp.MvcWebUI.ViewComponents
{
  public class TaskViewComponent : ViewComponent
  {
    private IStoryRepository storyRepository;

    public TaskViewComponent(ITaskRepository trepository, IStoryRepository srepository)
    {
      storyRepository = srepository;
    }
    public IViewComponentResult Invoke()
    {
      ViewBag.Stories = new SelectList(storyRepository.GetAll(), "StoryId", "Name");
      return View();
    }
  }
}
