using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOffice
{
     /**
     * Class Name : MovieName
     * Objective : To get and set data to the Mock data
     * @author : Ritika Jaiswal
     * Date : 18\04\22
     **/
    public class MovieData
    {
        public string MovieName { get; set; }
        public int NumberOfShows { get; set; }
        public long Revenue { get; set; }
        public string Status { get; set; }
        public int Weeks { get; set; }
        public MovieData(string movieName, int numberOfShows, long revenue, string status, int weeks)
        {
            this.MovieName = movieName;
            this.NumberOfShows = numberOfShows;
            this.Revenue = revenue;
            this.Status = status;
            this.Weeks = weeks;

        }
    }

    /**
    * Class Name :MovieRevenuePerMovieAndPerShows
    * Objective : To get and set data to the first method
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public class MovieRevenuePerMovieAndPerShows
    {
        public string MovieName { get; set; }
        public long Revenue { get; set; }
        public int Weeks { get; set; }
        public int NumberOfShows { get; set; }
        public long RevenuePerMoviePerShows { get; set; }

        public override string ToString()
        {
            return MovieName + "," + Weeks + "," + RevenuePerMoviePerShows;
        }
    }

    /**
    * Class Name :MovieTOtalRevenue
    * Objective : To get and set data to the second method
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public class MovieTOtalRevenue
    {
        public string MovieName { get; set; }
        public long Revenue { get; set; }
        public long TotalRevenue { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return MovieName + "," + TotalRevenue;
        }

    }

    /**
    * Class Name :MovieChangeInWeekly
    * Objective : To get and set data to the third method
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public class MovieChangeInWeekly
    {
        public string MovieName { get; set; }
        public string Status { get; set; }
        public int Weeks { get; set; }

        public override string ToString()
        {
            return MovieName + "," + Status + "," + Weeks;
        }

    }

    /**
    * Class Name :MoviePerfomanceOfRevenue
    * Objective : To get and set data to the fourth method
    * @author : Ritika Jaiswal
    * Date : 18\04\22
    **/
    public class MoviePerfomanceOfRevenue
    {
        public string MovieName { get; set; }
        public string Perfomance { get; set; }
        public long Revenue { get; set; }
        public int NumberOfShows { get; set; }

        public override string ToString()
        {
            return MovieName + "," + Perfomance + "," + Revenue;
        }
    }
}