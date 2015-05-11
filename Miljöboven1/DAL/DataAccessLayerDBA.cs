using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.DAL
{
    class DataAccessLayerDBA
    {
        private SqlConnection msqlConnection;
        private SqlDataAdapter mMoviesAdapter;
        private DataSet mDataSet;
        private String mConnectionString;

        public DataAccessLayerDBA()
        {
            mConnectionString = @"Data Source=RUBAND-SQLSERVE\RUBIRAMSSQLSERVE;Initial Catalog=Miljobrott;User ID=Miljobrott;Password=Miljobrott";
            //mConnectionString = MovieLibrary.Properties.Settings.Default.MovieLibraryConnectionString;

            msqlConnection = new SqlConnection(mConnectionString);

            msqlConnection.Open();

            //CreateIfNotExists(); // Setup the database

            msqlConnection.Close();
        }

        public void SaveMoviesToDatabase()
        {
            msqlConnection.Open();
            string sqlString;
            List<string> sqlList = new List<string>();
            /*MovieList movies = ServiceProvider.GetMovieService();*/
            SqlCommand cmd;
            /*sqlString = "delete from dbo.movies;";*/

            sqlString = "insert into Event (CrimeID,EventDate,EventComment) values(1,'2014-01-01','Ringt markägare...')";

            try
            {
                cmd = new SqlCommand(sqlString, msqlConnection);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            /*
            for (int i = 0; i < movies.Count(); i++)
            {
                sqlString = "insert into dbo.movies(id,title,genre,directorid,age,path,runtime) values(" +
                            movies.Get(i).getId() + ",'" +
                            movies.Get(i).getTitle() + "','" +
                            movies.Get(i).getGenre() + "'," +
                            movies.Get(i).getDirector() + "," +
                            movies.Get(i).getAge().ToString() + ",'" +
                            movies.Get(i).getPath() + "'," +
                            movies.Get(i).getTime().ToString() + ");";
                try
                {
                    cmd = new SqlCommand(sqlString, msqlConnection);
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    throw;
                }
            }
            */
            msqlConnection.Close();
        }


    }
}
