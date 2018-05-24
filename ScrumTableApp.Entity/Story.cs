using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTableApp.Entity
{
  public class Story
  {
    public int StoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public List<Task> Tasks { get; set; }
  }
}
