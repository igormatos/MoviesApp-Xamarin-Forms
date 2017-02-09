using System;
namespace MovieApp
{
	public class Movie
	{
		public String Title { get; set; }
		public String Overview { get; set; }
		public double Vote_average { get; set; }
		public String Category { get; set; }
		public String Poster_path { get; set; }
		public String Backdrop_path { get; set; }

		public Movie()
		{
		}

		//public string Poster_path
		//{
		//	get
		//	{
		//		return this.Poster_path;
		//	}

		//	set
		//	{
		//		this.Poster_path = "https://image.tmdb.org/t/p/w640/" + Poster_path;	
		//	}
		//}

		public Movie(String Title, String Overview, String Category) {
			this.Title = Title;
			this.Overview = Overview;
			this.Category = Category;
		}

	}
}
