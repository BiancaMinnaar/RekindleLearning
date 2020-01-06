using RekindleLearing.Trunk.Repository.Implementation;
using Xamarin.Forms; 
using RekindleLearing.Implementation.View;
using RekindleLearing.Trunk.View;
//#Bonsai Snippets - Usings

namespace RekindleLearing
{
    public partial class App : Application
    {
        public App()
        {

            InitializeComponent();
            var _MasterRepo = MasterRepository.MasterRepo;
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}