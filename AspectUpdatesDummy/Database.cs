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
       // public static string connStr =  @"Server=\\Mustang_07_VM\SQLExpress;"
          //   + @" AttachDbFilename=""C:\Aspect Productivity Technology\AspectPL\Database\AspectVersionDatabase.mdf"";"
          //   + @" Integrated Security=True; User Id=Shaun; Password=Windows10;";

        public static string connStr = @"Server=MUSTANG_07_VM\SQLEXPRESS; Database=AspectVersionDatabase; User Id=aspect; Password=aspect6;";

        public static SqlConnection GetConnection()
        {
            System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(connStr);

            return connection;
        }

        //
        //VERSION METHODS:
        //

        public static int InsertVersion(string id, string description, int type, string release_Date, bool blueAspect, bool redAspect, bool webApp, bool webService)
        {
            int return_code = 0;


            string insertStatement = "INSERT INTO Version " +
                "(ID, Description, Type, Release_Date, includeBlueAspect, includeRedAspect, includeWebApp, includeWebService) " +
                "VALUES (@id, @description, @type, @release_Date, @blue, @red, @app, @service)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@id", id);
            insertCommand.Parameters.AddWithValue("@description", description);
            insertCommand.Parameters.AddWithValue("@type", type);
            insertCommand.Parameters.AddWithValue("@release_Date", Convert.ToDateTime(release_Date));
            insertCommand.Parameters.AddWithValue("@blue", blueAspect);
            insertCommand.Parameters.AddWithValue("@red", redAspect);
            insertCommand.Parameters.AddWithValue("@app", webApp);
            insertCommand.Parameters.AddWithValue("@service", webService);

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
                    String description = SafeGetString(reader, 2);
                    int type = SafeGetInt(reader, 3);
                    DateTime release_date = SafeGetDate(reader, 4);
                    bool b = SafeGetBool(reader, 6);
                    bool r = SafeGetBool(reader, 7);
                    bool a = SafeGetBool(reader, 8);
                    bool s = SafeGetBool(reader, 9);

                    Version vers = new Version(pk, id, description, type, release_date, false, b, r, a, s);
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

        public static void UpdateVersion(int pk, string id, string description, int type, DateTime releaseDate, bool blueAspect, bool redAspect, bool webApp, bool webService)
        {
            string updateStatement = "UPDATE Version SET ID= @id, Description= @description," + 
                " Type= @type, Release_Date= @releaseDate," +
                " includeBlueAspect= @b, includeRedAspect= @r, includeWebApp= @a, includeWebService= @s" 
                + " WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@id", id);
            updateCommand.Parameters.AddWithValue("@pk", pk);
            updateCommand.Parameters.AddWithValue("@description", description);
            updateCommand.Parameters.AddWithValue("@type", type);
            updateCommand.Parameters.AddWithValue("@releaseDate", releaseDate);
            updateCommand.Parameters.AddWithValue("@b", blueAspect);
            updateCommand.Parameters.AddWithValue("@r", redAspect);
            updateCommand.Parameters.AddWithValue("@a", webApp);
            updateCommand.Parameters.AddWithValue("@s", webService);

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

        public static string getVersionID(int? versionPK)
        {
            if (versionPK == null)
            {
                return "";
            }
            
            string selectStatement = "SELECT ID FROM Version WHERE PK = @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@pk", versionPK);

            string id = "";

            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetString(0);
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

            return id;

        }

        public static int getLatestVersion()
        {
            string selectStatement = "SELECT MAX(PK) FROM Version";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            int pk = 1;

            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    pk = SafeGetInt(reader, 0);
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

            return pk;
        }

        //
        //CUSTOMER METHODS:
        //

        public static int InsertCustomer(string name, string details, string plc, string contacts, string logon, int versionPK)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO Customer " +
                "(Name, Details, VersionPK, plcAddress, Contacts, LogonDetail) " +
                "VALUES (@name, @details, @versionPK, @plc, @contacts, @logon)";
            
            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@details", details);
            insertCommand.Parameters.AddWithValue("@versionPK", versionPK);
            insertCommand.Parameters.AddWithValue("@plc", plc);
            insertCommand.Parameters.AddWithValue("@contacts", contacts);
            insertCommand.Parameters.AddWithValue("@logon", logon);
            
           

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

        public static int InsertCustomer(string name, string details, string plc, string contacts, string logon)
        {
            int return_code = 0;
            
            string insertStatement = "INSERT INTO Customer " +
                "(Name, Details, plcAddress, Contacts, LogonDetail) " +
                "VALUES (@name, @details, @plc, @contacts, @logon)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@name", name);
            insertCommand.Parameters.AddWithValue("@details", details);
            insertCommand.Parameters.AddWithValue("@plc", plc);
            insertCommand.Parameters.AddWithValue("@contacts", contacts);
            insertCommand.Parameters.AddWithValue("@logon", logon);

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
                    String details = SafeGetString(reader, 2);
                    int? versionPK;

                    if (reader.GetValue(3) == DBNull.Value)
                    {
                        versionPK = null;
                    }
                    else
                    {
                        versionPK = reader.GetInt32(3);
                    }

                    String plc = SafeGetString(reader, 5);
                    String contacts = SafeGetString(reader, 6);
                    String logon = SafeGetString(reader, 7);

                    Customer cust = new Customer(pk, name, details, plc, contacts,logon, versionPK, false);
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
            string selectStatement = "SELECT Customer.PK, Customer.Name, Customer.Details, Customer.VersionPK, Version.ID, Customer.plcAddress, Customer.Contacts, Customer.LogonDetail FROM Customer " +
              "LEFT JOIN Version ON Customer.VersionPK=Version.PK WHERE Customer.isDeleted=0 ORDER BY Customer.Name ASC";

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
                    String details = SafeGetString(reader, 2);
                    int? versionPK;
                    string versionID;
                    if (reader.GetValue(3) == DBNull.Value || reader.GetValue(3) == null)
                    {
                        versionPK = null;
                        versionID = "";
                    }
                    else
                    {
                        versionPK = reader.GetInt32(3);
                        versionID = reader.GetString(4);
                    }

                    String plc = SafeGetString(reader, 5);
                    String contacts = SafeGetString(reader, 6);
                    String logon = SafeGetString(reader, 7);
                   
                    Customer cust = new Customer(pk, name, details, plc, contacts, logon, versionPK, versionID, false);
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

        public static List<Customer> GetCustomersWithVersion(int vpk)
        {
            string selectStatement = "SELECT * FROM Customer WHERE VersionPK = @pk AND isDeleted =0";

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
                    String details = SafeGetString(reader, 2);
                    int versionPK = SafeGetInt(reader, 3);
                    String plc = SafeGetString(reader, 5);
                    String contacts = SafeGetString(reader, 6);
                    String logon = SafeGetString(reader, 7);

                    Customer cust = new Customer(pk, name, details, plc, contacts, logon, versionPK, "", false);
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

        public static void UpdateCustomer(int customerPK, string name, string details, string plc, string contacts, string logon)
        {
            string updateStatement = "UPDATE Customer SET Name= @name, Details = @details," +
               " plcAddress = @plc, Contacts = @contacts, LogonDetail = @logon WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@name", name);
            updateCommand.Parameters.AddWithValue("@pk", customerPK);
            updateCommand.Parameters.AddWithValue("@details", details);
            updateCommand.Parameters.AddWithValue("@plc", plc);
            updateCommand.Parameters.AddWithValue("@contacts", contacts);
            updateCommand.Parameters.AddWithValue("@logon", logon);

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

        public static void deleteCustomer(int customerPK)
        {
            string updateStatement = "UPDATE Customer SET isDeleted= @delete WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@pk", customerPK);

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

        public static string getCustomerName(int customerPK)
        {
            string selectStatement = "SELECT Name FROM Customer WHERE PK = @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@pk", customerPK);

            string name = "";

            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    name = SafeGetString(reader, 0);
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

            return name;
        }

        //
        //UPDATE METHODS:
        //

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

        public static int AddUpdate(int versionPK, int customerPK, DateTime expectedDate, DateTime? actualDate, string comment, int assigned)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO [Update] " +
                "(VersionPK, CustomerPK, Expected_Date, Actual_Date, Comment, AssignedTo) " +
                "VALUES (@versionPK, @customerPK, @expectedDate, @actualDate, @comment, @assigned)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@versionPK", versionPK);
            insertCommand.Parameters.AddWithValue("@customerPK", customerPK);
            insertCommand.Parameters.AddWithValue("@expectedDate", expectedDate);
            insertCommand.Parameters.AddWithValue("@comment", comment);

            if (assigned == 0)
            {
                insertCommand.Parameters.AddWithValue("@assigned", DBNull.Value);
            }
            else
            {
                insertCommand.Parameters.AddWithValue("@assigned", assigned);
            }
            


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
              "WHERE isDeleted =0 ORDER BY Expected_Date DESC";

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
                    String comment = SafeGetString(reader, 5);
                    bool isDeleted = SafeGetBool(reader, 6);
                    int? assignedTo = reader[7] as int?;

                    Update up = new Update(pk, versionPK, customerPK, expectedDate, actualDate, comment, isDeleted, assignedTo);
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

        public static List<Update> GetUpdatesWithVersion(int currentPK)
        {
            string selectStatement = "SELECT * FROM [Update] " +
              "WHERE isDeleted =0 AND VersionPK = @pk ORDER BY Expected_Date DESC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@pk", currentPK);

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
                    String comment = SafeGetString(reader, 5);
                    bool isDeleted = SafeGetBool(reader, 6);
                    int? assignedTo = reader[7] as int?;

                    Update up = new Update(pk, versionPK, customerPK, expectedDate, actualDate, comment, isDeleted, assignedTo);
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

        public static List<Update> GetAllUpdatesAssignedTo(int employeePK)
        {
            string selectStatement = "SELECT * FROM [Update] " +
                         "WHERE isDeleted =0 AND AssignedTo = @employeePK ORDER BY Expected_Date DESC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@employeePK", employeePK);

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
                    String comment = SafeGetString(reader, 5);
                    bool isDeleted = SafeGetBool(reader, 6);
                    int? assignedTo = reader[7] as int?;

                    Update up = new Update(pk, versionPK, customerPK, expectedDate, actualDate, comment, isDeleted, assignedTo);
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

        public static List<Update> GetIncompleteUpdatesAssignedTo(int employeePK)
        {
            string selectStatement = "SELECT * FROM [Update] " +
                         "WHERE isDeleted =0 AND AssignedTo = @employeePK AND Actual_Date IS NULL ORDER BY Expected_Date DESC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@employeePK", employeePK);

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
                    String comment = SafeGetString(reader, 5);
                    bool isDeleted = SafeGetBool(reader, 6);
                    int? assignedTo = reader[7] as int?;

                    Update up = new Update(pk, versionPK, customerPK, expectedDate, actualDate, comment, isDeleted, assignedTo);
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

        public static void UpdateUpdate(int pk, DateTime expectedDate, string comments, int assigned)
        {
            string updateStatement = "UPDATE [Update] SET Expected_Date= @expectedDate, Comment = @comments, AssignedTo = @assigned" +
               "  WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@expectedDate", expectedDate);
            updateCommand.Parameters.AddWithValue("@pk", pk);
            updateCommand.Parameters.AddWithValue("@comments", comments);
            updateCommand.Parameters.AddWithValue("@assigned", assigned);

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

        public static void UpdateUpdate(int pk, DateTime expectedDate, string comments, DateTime actualDate, int assigned)
        {
            string updateStatement = "UPDATE [Update] SET Expected_Date= @expectedDate, Comment = @comments, Actual_Date= @actualDate, AssignedTo = @assigned" +
               "  WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);

            updateCommand.Parameters.AddWithValue("@expectedDate", expectedDate);
            updateCommand.Parameters.AddWithValue("@actualDate", actualDate);
            updateCommand.Parameters.AddWithValue("@pk", pk);
            updateCommand.Parameters.AddWithValue("@comments", comments);
            updateCommand.Parameters.AddWithValue("@assigned", assigned);

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

        public static void deleteUpdate(int updatePK)
        {
            string updateStatement = "UPDATE [Update] SET isDeleted= @delete WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@pk", updatePK);

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

        //
        //EMPLOYEE METHODS:
        //

        public static List<Employee> GetEmployeeList()
        {
            string selectStatement = "SELECT PK, Name FROM Employee " +
              "WHERE isDeleted=0 ORDER BY Name ASC";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            List<Employee> employeeList = new List<Employee>();
            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    int pk = reader.GetInt32(0);
                    String name = SafeGetString(reader, 1);

                    Employee employee = new Employee(pk, name, false);
                    employeeList.Add(employee);
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

            return employeeList;
        }

        public static string getEmployeeName(int employeePK)
        {
            string selectStatement = "SELECT Name FROM Employee WHERE PK = @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            selectCommand.Parameters.AddWithValue("@pk", employeePK);

            string name = "";

            try
            {
                connection.Open();
                var reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    name = SafeGetString(reader, 0);
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

            return name;
        }

        public static int InsertEmployee(string name)
        {
            int return_code = 0;

            string insertStatement = "INSERT INTO Employee " +
                "(Name) " +
                "VALUES (@name)";

            SqlConnection connection = Database.GetConnection();
            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);

            insertCommand.Parameters.AddWithValue("@name", name);

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

        public static void deleteEmployee(int employeePK)
        {
            string updateStatement = "UPDATE Employee SET isDeleted= @delete WHERE PK= @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@pk", employeePK);

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
                removeEmployeeFromUpdates(employeePK);
            }
        }

        public static void removeEmployeeFromUpdates(int employeePK)
        {
            string updateStatement = "UPDATE [Update] SET AssignedTo = NULL WHERE AssignedTo = @pk";

            SqlConnection connection = Database.GetConnection();
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@pk", employeePK);

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

        //
        //SAFE READERS
        //
        public static string SafeGetString(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            else
                return string.Empty;
        }

        public static int SafeGetInt(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            else
                return 0;
        }

        public static DateTime SafeGetDate(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetDateTime(colIndex);
            else
                return DateTime.MinValue;
        }

        public static bool SafeGetBool(this SqlDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetBoolean(colIndex);
            else
                return false;
        }
    }
}
