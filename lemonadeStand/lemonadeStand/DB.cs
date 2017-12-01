using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lemonadeStand
{
    class DB
    {
        private SqlConnection seed = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\David\\Documents\\devCodeCamp\\lemonadeStand\\lemonadeStand\\lemonadeStand\\lemonadeStand\\PlayerScores.mdf; Integrated Security = True");

        public void addTodataBase(string name, double profit)
        {
            seed.Open();

            SqlCommand command = seed.CreateCommand();
            SqlTransaction transaction;

            transaction = seed.BeginTransaction();

            //establishing connection to db
            command.Connection = seed;
            command.Transaction = transaction;

            //write sql statment
            command.CommandText = "INSERT INTO Scores (Name,Score) VALUES ('" + name + "'," + profit + ") ";

            //preparing the SQL statment
            command.ExecuteNonQuery();

            //Executing the statement
            transaction.Commit();

        }

        public void getHighScores()
        {

            seed.Open();

            SqlCommand command = new SqlCommand("SELECT TOP 10 name,score FROM Scores ORDER BY score DESC", seed);
            SqlDataReader reader = command.ExecuteReader();
            Console.WriteLine("HIGH SCORES");
            Console.WriteLine("-----------");
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) +"\t"+ reader.GetDouble(1));
            }
            Console.WriteLine("");

        }
    }

}
