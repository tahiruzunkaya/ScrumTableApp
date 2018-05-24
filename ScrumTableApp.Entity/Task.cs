using System;
using System.Collections.Generic;
using System.Text;

namespace ScrumTableApp.Entity
{
  public class Task
  {
    public int TaskId { get; set; }
    public string Name { get; set; }
    public int Durum { get; set; }
    public string Description { get; set; }
    public int StoryId { get; set; }
    public Story Story { get; set; }
  }
}
