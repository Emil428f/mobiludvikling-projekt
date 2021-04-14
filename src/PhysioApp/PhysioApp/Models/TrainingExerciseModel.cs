using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhysioApp.Models
{
  public class TrainingExerciseModel
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<string> Images { get; set; }
    public string PreviewImage => Images.FirstOrDefault();
  }
}
