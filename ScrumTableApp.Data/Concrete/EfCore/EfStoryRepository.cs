using ScrumTableApp.Data.Abstract;
using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTableApp.Data.Concrete.EfCore
{
  

  
  public class EfStoryRepository : IStoryRepository
  {
    private TaskContext context;

    public EfStoryRepository(TaskContext _context)
    {
      context = _context;
    }
    public void AddStory(Story entity)
    {
      context.Stories.Add(entity);
      context.SaveChanges();
    }

    public void DeleteStory(int storyId)
    {
      var story = context.Stories.FirstOrDefault(p=>p.StoryId==storyId);
      if (story!=null)
      {

        context.Stories.Remove(story);
        context.SaveChanges();
      }
    }

    public IQueryable<Story> GetAll()
    {
      return context.Stories; 
    }

    public Story GetById(int storyId)
    {
      return context.Stories.FirstOrDefault(p=>p.StoryId==storyId);
    }

    public void updateStory(Story entity)
    {
      context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
      context.SaveChanges();
    }
  }
}
