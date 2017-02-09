using Xamarin.Forms;

namespace MovieApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var rootPage = new NavigationPage(new MainPage());

			rootPage.BarBackgroundColor = Color.FromHex("#081c24"); // auto-explicativo
			rootPage.BarTextColor = Color.FromHex("#daddde"); // auto-explicativo #	01d277

			// Define qual vai ser a página inicial
			MainPage = rootPage;
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