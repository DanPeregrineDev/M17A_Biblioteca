using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace M17A_Library
{
    public class Database
    {
        string databaseName;
        string connectionString;
        string databasePath;
        SqlConnection sqlConnection;

        public Database(string databaseName) 
        {
            this.databaseName = databaseName;

            connectionString += ConfigurationManager.ConnectionStrings["SQL"].ToString();

            databasePath = Utilities.ProgrammFolder("M17A_Library");
            databasePath += @"\" + databaseName + ".mdf";

            if (System.IO.File.Exists(databasePath) == false)
            {
                createDatabase();
            }

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlConnection.ChangeDatabase(this.databaseName);
        }

        void createDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            string sql = $@"IF EXISTS(SELECT * FROM Master.Sys.Databases
                            WHERE Name = '{this.databaseName}')
                            BEGIN
                                USE [Master];
                                EXEC sp_detach_db {this.databaseName}
                            END";

            SqlCommand command = new SqlCommand(sql, sqlConnection);
            command.ExecuteNonQuery();

            sql = $"CREATE DATABASE {this.databaseName} ON PRIMARY (NAME = {this.databaseName}, FILENAME = '{this.databasePath}')";

            command = new SqlCommand(sql, sqlConnection);
            command.ExecuteNonQuery();

            sqlConnection.ChangeDatabase(this.databaseName);

            sql = @"CREATE TABLE Books(
                  
                      nBook INT IDENTITY PRIMARY KEY,

                      Title VARCHAR(50) NOT NULL,
                      Author VARCHAR(100) NOT NULL,
                      Isbn VARCHAR(13) NOT NULL,
                      Year INT CHECK(ANO > 0) NOT NULL,
                      AquisitionDate DATE DEFAULT GETDATE(),
                      Price MONEY CHECK(Preco >= 0) NOT NULL,
                      CoverImage VARCHAR(500),
                      State BIT DEFAULT 1

                    )";

            command = new SqlCommand(sql, sqlConnection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public void ExecuteSQL(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, sqlConnection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            command.ExecuteNonQuery();
            command.Dispose();
        }

        public DataTable DevelopSQL(string sql, List<SqlParameter> parameters = null)
        {
            SqlCommand command = new SqlCommand(sql, sqlConnection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            SqlDataReader data = command.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(data);
            command.Dispose();
            data.Close();

            return table;
        }
    }
}
