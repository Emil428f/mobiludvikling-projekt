using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhysioApp.Pages
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class SendTrainingProgramPage : ContentPage
  {
    public SendTrainingProgramPage()
    {
      InitializeComponent();
    }

    private void SendButton_OnClicked(object sender, EventArgs e)
    {
      Navigation.PushAsync(new MainMenuPage());
    }
  }
}