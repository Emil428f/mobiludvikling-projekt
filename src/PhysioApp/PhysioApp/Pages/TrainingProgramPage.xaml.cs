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
  public partial class TrainingProgramPage : ContentPage
  {
    private TrainingProgramModel _trainingProgram;

    public TrainingProgramPage()
    {
      InitializeComponent();

      _trainingProgram = new TrainingProgramModel
      {
        Exercises = new List<TrainingExerciseModel>
        {
          new TrainingExerciseModel
          {
            Name = "Øvelse 1",
            Description = "2x armbøjninger",
            Images = new List<string>
            {
              "weight_lifting.jpg"
            }
          },
          new TrainingExerciseModel
          {
            Name = "Øvelse 1",
            Description = "254x armbøjninger",
            Images = new List<string>
            {
              "weight_lifting.jpg"
            }
          }
        }
      };

      BindingContext = _trainingProgram;
    }

    private void AddExerciseButton_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new TrainingExercisePage());
    }

    private void SendButton_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new SendTrainingProgramPage());
    }
  }
}