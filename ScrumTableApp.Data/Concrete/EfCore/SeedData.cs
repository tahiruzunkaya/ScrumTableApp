using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTableApp.Data.Concrete.EfCore
{
  public static class SeedData
  {
    public static void Seed(IApplicationBuilder app)
    {
      TaskContext context = app.ApplicationServices.GetRequiredService<TaskContext>();

      context.Database.Migrate();
      //if (!context.Stories.Any())
      //{
      //  context.Stories.AddRange(
      //    new Story() { Name="Story1" },
      //    new Story() { Name="Story2" }

      //    );
      //  context.SaveChanges();
      //}
      //if (!context.Tasks.Any())
      //{
      //  context.Tasks.AddRange(

      //    new ScrumTableApp.Entity.Task() {Name="tas1",StoryId=1 },
      //    new ScrumTableApp.Entity.Task() {Name="tas2"  ,StoryId=2},
      //    new ScrumTableApp.Entity.Task() {Name="tas3" ,StoryId=2},
      //    new ScrumTableApp.Entity.Task() {Name="tas4" ,StoryId=1}

      //    );
      //  context.SaveChanges();  
      //}
    }
  }
}
