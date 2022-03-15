using Xamarin.Forms;

namespace MonkeyTap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MonkeyTapWithSoundPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
