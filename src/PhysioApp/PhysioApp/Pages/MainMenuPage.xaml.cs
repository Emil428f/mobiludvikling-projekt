using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhysioApp.Pages
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class MainMenuPage : ContentPage
  {
    public MainMenuPage()
    {
      InitializeComponent();
    }

    private void SettingsButton_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new SettingsPage());
    }

    private void TrainingProgramButton_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new TrainingProgramPage());
    }
  }
}