using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ScrumTableApp.Data.Abstract;
using ScrumTableApp.Entity;
using ScrumTableApp.MvcWebUI.Models;

namespace ScrumTableApp.MvcWebUI.Controllers
{
  public class HomeController : Controller
  {
    private ITaskRepository taskRepository;
    private IStoryRepository storyRepository;

    public HomeController(ITaskRepository trepository,IStoryRepository srepository)
    {
      taskRepository = trepository;
      storyRepository = srepository;
    }
    public IActionResult Index()
    {
      
      return View();
    }


    [HttpPost]
    public IActionResult CreateStory(Story entity)
    {

      storyRepository.AddStory(entity);

      return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult CreateTask(Entity.Task entity)
    {
      entity.Durum = 1;
      taskRepository.AddTask(entity);
      return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult DurumDegis(int id,int durum)
    {
      int yeniDurum=1;
      if (durum == 1)
      {
        yeniDurum = 2;
      }else if (durum == 2)
      {
        yeniDurum = 3;
      }
      var entity = new Entity.Task();
      entity = taskRepository.GetById(id);
      entity.Durum = yeniDurum;
      taskRepository.updateTask(entity);

      return RedirectToAction("Index");

    }
    [HttpPost]
    public IActionResult TaskDelete(int id)
    {
      taskRepository.DeleteTask(id);

      return RedirectToAction("Index");
    }
  }
}
