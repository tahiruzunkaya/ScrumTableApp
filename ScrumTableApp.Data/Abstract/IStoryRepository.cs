using ScrumTableApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrumTableApp.Data.Abstract
{
  public interface IStoryRepository
  {
    Story GetById(int storyId);
    IQueryable<Story> GetAll();
    void AddStory(Story entity);
    void updateStory(Story entity);
    void DeleteStory(int storyId);
  }
}
