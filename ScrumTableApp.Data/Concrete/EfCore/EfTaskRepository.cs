using ScrumTableApp.Data.Abstract;
using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTableApp.Data.Concrete.EfCore
{
  public class EfTaskRepository : ITaskRepository
  {
    private TaskContext context;

    public EfTaskRepository(TaskContext _context)
    {
      context = _context;
    }
    public void AddTask(Task entity)
    {
      context.Tasks.Add(entity);
      context.SaveChanges();
    }

    public void DeleteTask(int taskId)
    {
      var task = context.Tasks.FirstOrDefault(p => p.TaskId == taskId);
      if (task != null)
      {
        context.Tasks.Remove(task);
        context.SaveChanges();

      }
    }

    public IQueryable<Task> GetAll()
    {
      return context.Tasks;
    }

    public Task GetById(int taskId)
    {
      return context.Tasks.FirstOrDefault(p => p.TaskId == taskId);
    }

    public void updateTask(Task entity)
    {
      context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
    }
  }
}
