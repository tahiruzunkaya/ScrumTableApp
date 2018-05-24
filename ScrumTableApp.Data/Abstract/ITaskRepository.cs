using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTableApp.Data.Abstract
{
  public interface ITaskRepository
  {
    Task GetById(int taskId);
    IQueryable<Task> GetAll();
    void AddTask(Task entity);
    void updateTask(Task entity);
    void DeleteTask(int taskId);
  }
}
