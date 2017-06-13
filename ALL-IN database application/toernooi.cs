using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_IN_database_application
{
    class Toernooi : DatabaseConnection
    {

        public Toernooi()
        {

        }


        public List<OpgehaaldeItems> KrijgDingen()
        {
            List<OpgehaaldeItems> genres = new List<OpgehaaldeItems>();
            {

                try
                {
                    connect.Open();

                    string selectQuery = @"SELECT * FROM toernooi";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, connect);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        double kosten = dataReader.GetDouble("kosten");
                        OpgehaaldeItems ophaal = new OpgehaaldeItems { kosten = kosten };

                        genres.Add(ophaal);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("alles is kapot" + ex);
                }
                finally
                {
                    connect.Close();
                }

                return genres;
            }
        }
    }
}
