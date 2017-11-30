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
    }

}
