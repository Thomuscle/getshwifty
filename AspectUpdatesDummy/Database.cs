using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectUpdatesDummy
{
    public static class Database
    {
        public static string connStr =  @"Data Source = (LocalDB)\V11.0;"
             + @" AttachDbFilename=""C:\Users\shaun\Documents\Visual Studio 2013\Projects\AspectUpdatesDummy\AspectUpdatesDummy\VersionDatabase1.mdf"";"
             + @" Integrated Security=True";

        public static SqlConnection GetConnection()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connStr);

            return connection;
        }

        public static int InsertVersion(string id, string description, int type, string release_Date)
        {
            int return_code = 0;


            string insertStatement = "INSERT INTO Version " +
                "(ID, Description, Type, Release_Date) " +
                "VALUES (@id, @description, @type, @release_Date)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@id", id);
            insertCommand.Parameters.AddWithValue("@description", description);
            insertCommand.Parameters.AddWithValue("@type", type);
            insertCommand.Parameters.AddWithValue("@release_Date", Convert.ToDateTime(release_Date));

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return return_code;
        }

        public static List<Version> GetVersionList()
        {
            string selectStatement = "SELECT * FROM Version " +
               "WHERE isDeleted=0 ORDER BY Release_Date DESC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            List<Version> versionList = new List<Version>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    String id = reader.GetString(1);
                    String description = reader.GetString(2);
                    int type = reader.GetInt32(3);
                    DateTime release_date = reader.GetDateTime(4);

                    Version vers = new Version(pk, id, description, type, release_date, false);
                    versionList.Add(vers);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return versionList;
        }

        public static int InsertCustomer(string name, string details, int versionPK)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO Customer " +
                "(Name, Details, VersionPK) " +
                "VALUES (@name, @details, @versionPK)";
            
            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@details", details);
            insertCommand.Parameters.AddWithValue("@versionPK", versionPK);
            
           

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return return_code;
        }


        public static List<Customer> GetCustomerList()
        {
            string selectStatement = "SELECT * FROM Customer " +
              "WHERE isDeleted=0 ORDER BY Name ASC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            List<Customer> customerList = new List<Customer>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String details = reader.GetString(2);
                    int versionPK = reader.GetInt32(3);

                    Customer cust = new Customer(pk, name, details, versionPK, false);
                    customerList.Add(cust);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return customerList;
        }


        public static List<Customer> GetCustomerListWithID()
        {
            string selectStatement = "SELECT Customer.PK, Customer.Name, Customer.Details, Customer.VersionPK, Version.ID FROM Customer " +
              "LEFT JOIN Version ON Customer.VersionPK=Version.PK ORDER BY Customer.Name ASC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            List<Customer> customerList = new List<Customer>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String details = reader.GetString(2);
                    int versionPK = reader.GetInt32(3);
                    string versionID = reader.GetString(4);

                    Customer cust = new Customer(pk, name, details, versionPK, versionID, false);
                    customerList.Add(cust);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return customerList;
        }

        public static int UpdateCustomer(int customerPK)
        {
            string versionPKStatement = "SELECT MAX(PK) FROM Version";

            SqlConnection connection = Database.GetConnection();
            SqlCommand versionPKCommand = new SqlCommand(versionPKStatement, connection);

            int pk = 1;
            try
            {
                connection.Open();
                var reader = versionPKCommand.ExecuteReader();
                while (reader.Read())
                {
                    pk = reader.GetInt32(0);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            string updateStatement = "UPDATE Customer SET VersionPK=" + pk + " WHERE PK=" + customerPK;

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return pk;
        }

        public static void UpdateCustomer(int customerPK, int versionPK)
        {

            string updateStatement = "UPDATE Customer SET VersionPK=" + versionPK + " WHERE PK=" + customerPK;
            
            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }


        }


        public static int AddUpdate(int versionPK, int customerPK)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO [Update] " +
                "(VersionPK, CustomerPK) " +
                "VALUES (@versionPK, @customerPK)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            
            insertCommand.Parameters.AddWithValue("@versionPK", versionPK);
            insertCommand.Parameters.AddWithValue("@customerPK", customerPK);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return return_code;
        }

        public static int AddUpdate(int versionPK, int customerPK, DateTime expectedDate, DateTime? actualDate, string comment)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO [Update] " +
                "(VersionPK, CustomerPK, Expected_Date, Actual_Date, Comment) " +
                "VALUES (@versionPK, @customerPK, @expectedDate, @actualDate, @comment)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@versionPK", versionPK);
            insertCommand.Parameters.AddWithValue("@customerPK", customerPK);
            insertCommand.Parameters.AddWithValue("@expectedDate", expectedDate);
            insertCommand.Parameters.AddWithValue("@comment", comment);


            if (actualDate == null)
            {
                insertCommand.Parameters.AddWithValue("@actualDate", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@actualDate", actualDate);
            }
            


            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                return_code = 1;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return return_code;
        }


        public static List<Update> GetUpdateList()
        {
            string selectStatement = "SELECT * FROM [Update] " +
              "ORDER BY Expected_Date DESC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            List<Update> updateList = new List<Update>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    int versionPK = reader.GetInt32(1);
                    int customerPK = reader.GetInt32(2);
                    DateTime? expectedDate = reader[3] as DateTime?;
                    DateTime? actualDate = reader[4] as DateTime?;
                    String comment = Convert.ToString(reader.GetValue(5));
                    bool isDeleted = reader.GetBoolean(6);

                    Update up = new Update(pk, versionPK, customerPK, expectedDate, actualDate, comment, isDeleted);
                    updateList.Add(up);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return updateList;
        }

        public static void UpdateVersion(int pk, string id, string description, int type, DateTime releaseDate)
        {
            string updateStatement = "UPDATE Version SET ID= @id, Description= @description," + 
                " Type= @type, Release_Date= @releaseDate WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@id", id);
            updateCommand.Parameters.AddWithValue("@pk", pk);
            updateCommand.Parameters.AddWithValue("@description", description);
            updateCommand.Parameters.AddWithValue("@type", type);
            updateCommand.Parameters.AddWithValue("@releaseDate", releaseDate);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        public static void deleteVersion(int pk)
        {
            string updateStatement = "UPDATE Version SET isDeleted= @delete WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@pk", pk);

            bool delete = true;
            updateCommand.Parameters.AddWithValue("@delete", delete);

            try
            {
                connection.Open();
                updateCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Customer> GetCustomersWithVersion(int vpk)
        {
            string selectStatement = "SELECT * FROM Customer WHERE VersionPK = @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@pk", vpk);

            List<Customer> customerList = new List<Customer>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    String name = reader.GetString(1);
                    String details = reader.GetString(2);
                    int versionPK = reader.GetInt32(3);

                    Customer cust = new Customer(pk, name, details, versionPK, "", false);
                    customerList.Add(cust);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return customerList;
        }
    }
}
