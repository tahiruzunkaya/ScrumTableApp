using Microsoft.EntityFrameworkCore;
using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTableApp.Data.Concrete.EfCore
{
  public class TaskContext : DbContext
  {
    public TaskContext(DbContextOptions<TaskContext> options)
      :base(options)
    {
        
    }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<Story> Stories { get; set; }
  }
}
