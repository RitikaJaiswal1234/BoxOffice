using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOffice
{
    /**
    * Interfcae Name :IMoviesDetails
    * Objective : Give all method defination.
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public interface IMoviesDetails
    {
        public List<MovieRevenuePerMovieAndPerShows> getMovieRevenuePerMovieAndPerShows (List<MovieData> list);
        public List<MovieTOtalRevenue> getMovieTOtalRevenues (List<MovieData> list);
        public List<MovieChangeInWeekly> getMovieChangeInWeeklies (List<MovieData> list);
        public List<MoviePerfomanceOfRevenue> getMoviePerfomanceOfRevenues (List <MovieData> list);
    }
}
