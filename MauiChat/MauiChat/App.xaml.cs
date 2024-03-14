using Syncfusion.Maui.Chat;
using System.Globalization;
using System.Resources;

namespace MauiChat
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();             
            CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");   
            SfChatResources.ResourceManager = new ResourceManager("MauiChat.Resources.SfChat", Application.Current!.GetType().Assembly);
            MainPage = new MainPage();
        }
    }
}
