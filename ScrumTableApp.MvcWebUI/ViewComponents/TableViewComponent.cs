using Microsoft.AspNetCore.Mvc;
using ScrumTableApp.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScrumTableApp.MvcWebUI.ViewComponents
{
  public class TableViewComponent : ViewComponent
  {
    private IStoryRepository storyRepository;
    private ITaskRepository taskRepository;

    public TableViewComponent(ITaskRepository trepository, IStoryRepository srepository)
    {
      storyRepository = srepository;
      taskRepository = trepository;
    }
    public IViewComponentResult Invoke()
    {
      ViewBag.Tasks = taskRepository.GetAll();
      return View(storyRepository.GetAll());

    }
  }
}
