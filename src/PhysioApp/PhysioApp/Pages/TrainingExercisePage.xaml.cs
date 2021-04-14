using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhysioApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhysioApp.Pages
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class TrainingExercisePage : ContentPage
  {
    private TrainingExerciseModel _trainingExercise;

    public TrainingExercisePage()
    {
      InitializeComponent();

      _trainingExercise = new TrainingExerciseModel
      {
        Images = new List<string>
        {
          "weight_lifting.jpg",
          "weight_lifting.jpg",
          "weight_lifting.jpg"
        }
      };

      BindingContext = _trainingExercise;
    }
  }
}