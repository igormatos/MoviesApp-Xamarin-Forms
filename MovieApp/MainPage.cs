using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace MovieApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			ToolbarItems.Add(new ToolbarItem("Bookmarks", "ic_bookmark.png", async () =>
			{
				// TODO: Bookmarks
				var result = await DisplayAlert("Title", "Message", "Accept", "Cancel");

			}));

		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			//var list = new ObservableCollection<Movie>();
			//list.Add(new Movie("The Secret Life of Pets", "The quiet life of a terrier named Max is upended when his owner takes in Duke, a stray whom Max instantly dislikes", "Animação, Comedia"));
			//list.Add(new Movie("Suicide Squad", "From DC Comics comes the Suicide Squad, an antihero team of incarcerated supervillains who act as deniable assets for the United States government, undertaking high-risk black ops missions in exchange for commuted prison sentences", "Animação, Comedia"));
			//moviesListView.ItemsSource = list;

			var service = new Service();
			moviesListView.ItemsSource = await service.GetPopularMovies();

		}

		void OnMovieSelected(object sender, EventArgs args)
		{
			var list = (ListView) sender;
			var selected = list.SelectedItem as Movie;
			
			list.SelectedItem = null;

			Debug.WriteLine(selected.Title);

			var detailPage = new DetailPage();

			// Passar o filme para a próxima tela
			detailPage.BindingContext = selected;

			Navigation.PushAsync(detailPage);

		}

	}
}
