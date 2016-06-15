using System;
using System.Data.SqlClient;
using WebApiApplication.Repositories.Abstractions;

namespace WebApiApplication.Repositories.Implementations
{
    public class RRSqlRepository : ISqlRepository
    {
        private readonly string _connectionString;

        public RRSqlRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public string GetAll()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    var commandText = "SELECT * FROM RRUser";

                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        conn.Open();
                        using (var dr = cmd.ExecuteReader())   
                        {
                            if (dr.HasRows)
                            {
                                return "OK";
                            }

                            return "FALSE";
                        }
                    }
                }
            }
            catch (Exception)
            {
                return "Repository";                
            }            
        }
    }
}