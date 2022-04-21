using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOffice
{

    /**
    * Class Name : MovieDetailsImpl 
    * Objective : To Implement all the methods that defined to Interface
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public class MovieDetailsImpl : IMoviesDetails
    {
        /**
         * Method Name : getMovieRevenuePerMovieAndPerShows
         * Objective : Give revenue per movie per shows in week-1 and week-2			
         * Input : List Of the MovieData
         * Output : Finalresult
         * */
        public List<MovieRevenuePerMovieAndPerShows> getMovieRevenuePerMovieAndPerShows(List<MovieData> list)
        {
            /*Dictionary<Tuple<string, int>, MovieRevenuePerMovieAndPerShows> dictionary = new Dictionary<Tuple<string, int>, MovieRevenuePerMovieAndPerShows>();

            foreach (MovieData movie in list)
            {
                if (dictionary.ContainsKey(new Tuple<string, int>(movie.MovieName, movie.Weeks)))
                {
                    MovieRevenuePerMovieAndPerShows movieRevenuePerMovieAndPerShows = dictionary[new Tuple<string, int>(movie.MovieName, movie.Weeks)];
                    movieRevenuePerMovieAndPerShows.MovieName = movie.MovieName;
                    movieRevenuePerMovieAndPerShows.Weeks = movie.Weeks;
                    movieRevenuePerMovieAndPerShows.RevenuePerMoviePerShows = movie.Revenue / movie.NumberOfShows;

                }
                else
                {
                    MovieRevenuePerMovieAndPerShows movieRevenuePerMovieAndPerShows = new MovieRevenuePerMovieAndPerShows();
                    movieRevenuePerMovieAndPerShows.MovieName = movie.MovieName;
                    movieRevenuePerMovieAndPerShows.Weeks = movie.Weeks;
                    movieRevenuePerMovieAndPerShows.RevenuePerMoviePerShows = movie.Revenue / movie.NumberOfShows;
                    dictionary.Add(new Tuple<string, int>(movie.MovieName, movie.Weeks), movieRevenuePerMovieAndPerShows);
                }
            }
            List<MovieRevenuePerMovieAndPerShows> finalResult = new List<MovieRevenuePerMovieAndPerShows>();
            foreach (var element in dictionary)
            {

                finalResult.Add(element.Value);
            }
            return finalResult;
            
        */
            List<MovieRevenuePerMovieAndPerShows> finalResult = new List<MovieRevenuePerMovieAndPerShows>();
            foreach (MovieData movie in list)
            {
                MovieRevenuePerMovieAndPerShows obj = new MovieRevenuePerMovieAndPerShows();
                obj.MovieName = movie.MovieName;
                obj.Weeks = movie.Weeks;
                obj.RevenuePerMoviePerShows = movie.Revenue / movie.NumberOfShows;
                finalResult.Add(obj);
            }

            return finalResult;
        }

        /**
         * Method Name : getMovieTOtalRevenues
         * Objective : Give total revenue for all hit movie across all weeks		
         * Input : List Of the MovieData
         * Output : result
         * */
        public List<MovieTOtalRevenue> getMovieTOtalRevenues(List<MovieData> list)
        {
            Dictionary<string, MovieTOtalRevenue> dict = new Dictionary<string, MovieTOtalRevenue>();
            foreach (MovieData movieData in list)
            {
                if (dict.ContainsKey(movieData.MovieName))
                {
                    MovieTOtalRevenue movieTOtalRevenue = dict[movieData.MovieName];
                    movieTOtalRevenue.MovieName = movieData.MovieName;
                    if (movieData.Status == "Hit")
                        movieTOtalRevenue.TotalRevenue += movieData.Revenue;
                }
                else
                {
                    MovieTOtalRevenue movieTOtalRevenue = new MovieTOtalRevenue();
                    movieTOtalRevenue.MovieName = movieData.MovieName;
                    if (movieData.Status == "Hit")
                        movieTOtalRevenue.TotalRevenue = movieData.Revenue;
                    dict.Add(movieData.MovieName, movieTOtalRevenue);
                }

            }
            List<MovieTOtalRevenue> result = new List<MovieTOtalRevenue>();
            foreach (var element in dict)
            {
                result.Add(element.Value);
            }

            return result;
        }


        /**
        * Method Name : getMovieChangeInWeeklies
        * Objective : Show movies which are changed in status in weekly level				
        * Input : List Of the MovieData
        * Output : result(Give the movie name which status are changed in weekly)
        * */
        public List<MovieChangeInWeekly> getMovieChangeInWeeklies(List<MovieData> list)
        {
            Dictionary<string, MovieChangeInWeekly> dic = new Dictionary<string, MovieChangeInWeekly>();
            List<MovieChangeInWeekly> result = new List<MovieChangeInWeekly>();
            foreach (MovieData movieData in list)

            {

                MovieChangeInWeekly movieChangeInWeekly = new MovieChangeInWeekly();
                if (dic.ContainsKey(movieData.MovieName))
                {

                    if (movieData.Status != dic[movieData.MovieName].Status)
                    {

                        movieChangeInWeekly.MovieName = movieData.MovieName;
                        movieChangeInWeekly.Status = movieData.Status;
                        movieChangeInWeekly.Weeks = movieData.Weeks;
                        result.Add(movieChangeInWeekly);
                        result.Add(dic[movieData.MovieName]);

                    }
                }
                else
                {

                    movieChangeInWeekly.MovieName = movieData.MovieName;
                    movieChangeInWeekly.Status = movieData.Status;
                    movieChangeInWeekly.Weeks = movieData.Weeks;
                    dic.Add(movieData.MovieName, movieChangeInWeekly);
                }
            }
            return result;
        }

        /**
          * Method Name :getMoviePerfomanceOfRevenues
          * Objective :Show revenue per show increase or decrease for movies on week-2 compare to week-1 level								
          * Input : List Of the MovieData
          * Output : result(Give the )
          * */
        public List<MoviePerfomanceOfRevenue> getMoviePerfomanceOfRevenues(List<MovieData> list)
        {
            Dictionary<string, MoviePerfomanceOfRevenue> dict = new Dictionary<string, MoviePerfomanceOfRevenue>();
            List<MoviePerfomanceOfRevenue> result = new List<MoviePerfomanceOfRevenue>();
            foreach (MovieData movieData in list)
            {
                if (dict.ContainsKey(movieData.MovieName))
                {
                    MoviePerfomanceOfRevenue moviePerfomanceOfRevenue = new MoviePerfomanceOfRevenue();
                    moviePerfomanceOfRevenue.MovieName = movieData.MovieName;
                    moviePerfomanceOfRevenue.Revenue = movieData.Revenue / movieData.NumberOfShows;
                    if (dict[movieData.MovieName].Revenue >= moviePerfomanceOfRevenue.Revenue)
                    {
                        moviePerfomanceOfRevenue.Perfomance = "increment";
                        moviePerfomanceOfRevenue.Revenue = dict[movieData.MovieName].Revenue - moviePerfomanceOfRevenue.Revenue;
                        result.Add(moviePerfomanceOfRevenue);
                    }
                    else
                    {
                        moviePerfomanceOfRevenue.Perfomance = "decrement";
                        moviePerfomanceOfRevenue.Revenue = dict[movieData.MovieName].Revenue - moviePerfomanceOfRevenue.Revenue;
                        result.Add(moviePerfomanceOfRevenue);
                    }

                }
                else
                {
                    MoviePerfomanceOfRevenue moviePerfomanceOfRevenue = new MoviePerfomanceOfRevenue();
                    moviePerfomanceOfRevenue.MovieName = movieData.MovieName;
                    moviePerfomanceOfRevenue.Revenue = movieData.Revenue / movieData.NumberOfShows;
                    dict.Add(movieData.MovieName, moviePerfomanceOfRevenue);

                }
            }
            return result;
        }

    }
}

