using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOffice
{
        /**
        * Class Name : Executer
        * Objective : Calling all methods to the corresponding Project & gives the result. 
        * @author : Ritika Jaiswal
        * Date : 18\04\22
        * */
    public class Executer
    {
        public static void Main(String[] args)
        {
            //Create a list to store mock data
            List<MovieData> listOfMovies = new List<MovieData>();
            listOfMovies.Add(new MovieData("RRR", 60, 400000000, "Hit", 1));
            listOfMovies.Add(new MovieData("KGF", 90, 75000000, "Hit", 1));
            listOfMovies.Add(new MovieData("Attack", 35, 800000000, "Average", 1));
            listOfMovies.Add(new MovieData("Spiderman", 120, 900000000, "Hit", 1));
            listOfMovies.Add(new MovieData("RRR", 40, 300000000, "Hit", 2));
            listOfMovies.Add(new MovieData("KGF", 60, 450000000, "Hit", 2));
            listOfMovies.Add(new MovieData("Attack", 45, 950000000, "Hit", 2));
            listOfMovies.Add(new MovieData("Spiderman", 65, 300000000, "Average", 2));

            //Create Object to the corresponding class where these all methods are access
            MovieDetailsImpl MovieDetailsImpl = new MovieDetailsImpl();

            //Calling First Method & give the output 
            Console.WriteLine("Find revenue per Movie per shows in week-1 and week-2 :");
            List<MovieRevenuePerMovieAndPerShows> finalResul1 = MovieDetailsImpl.getMovieRevenuePerMovieAndPerShows(listOfMovies);

            foreach (MovieRevenuePerMovieAndPerShows movieRevenuePerMovieAndPerShows in finalResul1)
            {
                Console.WriteLine(movieRevenuePerMovieAndPerShows);
            }
            Console.WriteLine();

            //Calling Second Method & give the output 
            Console.WriteLine("Find total revenue for all hit movie across all weeks : ");
            List<MovieTOtalRevenue> finalresult2 = MovieDetailsImpl.getMovieTOtalRevenues(listOfMovies);
            foreach (MovieTOtalRevenue movieTOtalRevenue in finalresult2)
            {
                Console.WriteLine(movieTOtalRevenue);
            }
            Console.WriteLine();

            //Calling Third Method & give the output
            Console.WriteLine("Show movies which are changed in status in weekly level : ");
            List<MovieChangeInWeekly> finalresult3 = MovieDetailsImpl.getMovieChangeInWeeklies(listOfMovies);
            foreach (MovieChangeInWeekly movieChangeInWeekly in finalresult3)
            {
                Console.WriteLine(movieChangeInWeekly);
            }
            Console.WriteLine();

            //Calling fourth Method & give the output
            Console.WriteLine("Show revenue per show increase or decrease for movies on week-2 compare to week-1 level : ");
            List<MoviePerfomanceOfRevenue> finalResult4 = MovieDetailsImpl.getMoviePerfomanceOfRevenues(listOfMovies);
            foreach (MoviePerfomanceOfRevenue moviePerfomanceOfRevenue in finalResult4)
            {
                Console.WriteLine(moviePerfomanceOfRevenue);
            }

        }
    }
}
