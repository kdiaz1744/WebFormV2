using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormv2.Classes
{

    public class OMSOperations
    {

        //This function takes UserName, and finds the account associated with it, and then returns if it was found or not
        public Users FindUserViaUserName(string UserName)
        {

            Users result = new Users();
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("FindUserViaUserName", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserName", UserName);

                    dbconnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //--Pass values individually because I only need the first row
                            if (!reader.IsDBNull(0)) result.UserID = Convert.ToInt32(reader[0].ToString());
                            if (!reader.IsDBNull(1)) result.UserName = reader[1].ToString();
                            if (!reader.IsDBNull(2)) result.FirstName = reader[2].ToString();
                            if (!reader.IsDBNull(3)) result.LastName = reader[3].ToString();
                            if (!reader.IsDBNull(4)) result.Email = reader[4].ToString();
                            if (!reader.IsDBNull(5)) result.Adress = reader[5].ToString();
                            if (!reader.IsDBNull(6)) result.City = reader[6].ToString();
                            if (!reader.IsDBNull(7)) result.State = reader[7].ToString();
                            if (!reader.IsDBNull(8)) result.ZipCode = reader[8].ToString();
                            if (!reader.IsDBNull(9)) result.PhoneNumber = reader[9].ToString();
                            //--Foreign Key values--
                            if (!reader.IsDBNull(10)) result.RoleID = Convert.ToInt32(reader[10].ToString());
                            if (!reader.IsDBNull(11)) result.StatusID = Convert.ToInt32(reader[11].ToString());
                            if (!reader.IsDBNull(12)) result.PictureID = Convert.ToInt32(reader[12].ToString());
                            result.Ex = "Found";
                        }
                        else
                        {
                            result.Ex = "None";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    result.Ex = ex.ToString();
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        //This function takes UserID, and finds the account associated with it, and then returns if it was found or not
        public Users FindUserViaUserID(string id)
        {

            Users result = new Users();
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("FindUserViaUserID", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserID", id);

                    dbconnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //--Pass values individually because I only need the first row
                            if (!reader.IsDBNull(0)) result.UserID = Convert.ToInt32(reader[0].ToString());
                            if (!reader.IsDBNull(1)) result.UserName = reader[1].ToString();
                            if (!reader.IsDBNull(2)) result.FirstName = reader[2].ToString();
                            if (!reader.IsDBNull(3)) result.LastName = reader[3].ToString();
                            if (!reader.IsDBNull(4)) result.Email = reader[4].ToString();
                            if (!reader.IsDBNull(5)) result.Adress = reader[5].ToString();
                            if (!reader.IsDBNull(6)) result.City = reader[6].ToString();
                            if (!reader.IsDBNull(7)) result.State = reader[7].ToString();
                            if (!reader.IsDBNull(8)) result.ZipCode = reader[8].ToString();
                            if (!reader.IsDBNull(9)) result.PhoneNumber = reader[9].ToString();
                            //--Foreign Key values--
                            if (!reader.IsDBNull(10)) result.RoleID = Convert.ToInt32(reader[10].ToString());
                            if (!reader.IsDBNull(11)) result.StatusID = Convert.ToInt32(reader[11].ToString());
                            if (!reader.IsDBNull(12)) result.PictureID = Convert.ToInt32(reader[12].ToString());
                            result.Ex = "Found";
                        }
                        else
                        {
                            result.Ex = "None";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    result.Ex = ex.ToString();
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }



        //This function takes UserName and Password, and finds the account associated with it, then returns a string with the answer and whether
        // an error was found
        public Users ValidateUser(string UserName, string Password)
        {

            Users result = new Users();
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ValidateUserViaUserName", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserName", UserName);
                    cmd.Parameters.AddWithValue("Password", Password);


                    dbconnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        //if (reader.HasRows)
                        {
                            //--Pass values individually because I only need the first row
                            if (!reader.IsDBNull(0)) result.UserID = Convert.ToInt32(reader[0].ToString());
                            if (!reader.IsDBNull(1)) result.UserName = reader[1].ToString();
                            if (!reader.IsDBNull(2)) result.FirstName = reader[2].ToString();
                            if (!reader.IsDBNull(3)) result.LastName = reader[3].ToString();
                            if (!reader.IsDBNull(4)) result.Email = reader[4].ToString();
                            if (!reader.IsDBNull(5)) result.Adress = reader[5].ToString();
                            if (!reader.IsDBNull(6)) result.City = reader[6].ToString();
                            if (!reader.IsDBNull(7)) result.State = reader[7].ToString();
                            if (!reader.IsDBNull(8)) result.ZipCode = reader[8].ToString();
                            if (!reader.IsDBNull(9)) result.PhoneNumber = reader[9].ToString();
                            //--Foreign Key values--
                            if (!reader.IsDBNull(10)) result.RoleID = Convert.ToInt32(reader[10].ToString());
                            if (!reader.IsDBNull(11)) result.StatusID = Convert.ToInt32(reader[11].ToString());
                            if (!reader.IsDBNull(12)) result.PictureID = Convert.ToInt32(reader[12].ToString());
                            if (!reader.IsDBNull(13)) result.Initial = Convert.ToBoolean(reader[13].ToString());

                            result.Ex = "Found";
                        }
                        else
                        {
                            result.Ex = "None";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    result.Ex = "Failed Connection " + ex.Message; ;
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        //This function adds a user to UserInfo and UserCredentials, and returns a string with the result
        public string AddUser(Users NUser)
        {

            string result;
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("InsertNewUser", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserName", NUser.UserName);
                    cmd.Parameters.AddWithValue("FirstName", NUser.FirstName);
                    cmd.Parameters.AddWithValue("LastName", NUser.LastName);
                    cmd.Parameters.AddWithValue("Email", NUser.Email);
                    cmd.Parameters.AddWithValue("Adress", NUser.Adress);
                    cmd.Parameters.AddWithValue("City", NUser.City);
                    cmd.Parameters.AddWithValue("State", NUser.State);
                    cmd.Parameters.AddWithValue("ZipCode", NUser.ZipCode);
                    cmd.Parameters.AddWithValue("PhoneNumber", NUser.PhoneNumber);
                    cmd.Parameters.AddWithValue("RoleID", NUser.RoleID);
                    cmd.Parameters.AddWithValue("StatusID", NUser.StatusID);
                    cmd.Parameters.AddWithValue("Password", NUser.Password);
                    dbconnection.Open();
                    int ARows = cmd.ExecuteNonQuery();

                    if (ARows == 0) result = string.Format("User {0} not added to database.", NUser.UserName);
                    else result = string.Format("User {0} added to database.", NUser.UserName);
                }
                catch (SqlException ex)
                {
                    result = "Failed Connection " + ex.Message; ;
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        //This function returns the whole Players table
        //[WebMethod(EnableSession = true)]
        public static ArrayList AllUsers()
        {
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            var sqlDa = new DataTable();
            var user = new Users();
            var UserList = new ArrayList();

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GetAllUsers", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    dbconnection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(sqlDa);
                }
                catch (SqlException ex)
                {

                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            } //end retrieving users
            foreach (DataRow row in sqlDa.Rows)
            {
                user = new Users();
                if (!row["UserID"].ToString().Equals(String.Empty))
                {
                    user.UserID = Convert.ToInt32(row["UserID"].ToString());
                }
                if (!row["UserName"].ToString().Equals(String.Empty))
                {
                    user.UserName = row["UserName"].ToString();
                }
                if (!row["FirstName"].ToString().Equals(String.Empty))
                {
                    user.FirstName = row["FirstName"].ToString();
                }
                if (!row["LastName"].ToString().Equals(String.Empty))
                {
                    user.LastName = row["LastName"].ToString();
                }
                if (!row["Email"].ToString().Equals(String.Empty))
                {
                    user.Email = row["Email"].ToString();
                }
                if (!row["Adress"].ToString().Equals(String.Empty))
                {
                    user.Adress = row["Adress"].ToString();
                }
                if (!row["City"].ToString().Equals(String.Empty))
                {
                    user.City = row["City"].ToString();
                }
                if (!row["State"].ToString().Equals(String.Empty))
                {
                    user.State = row["State"].ToString();
                }
                if (!row["ZipCode"].ToString().Equals(String.Empty))
                {
                    user.ZipCode = row["ZipCode"].ToString();
                }
                if (!row["PhoneNumber"].ToString().Equals(String.Empty))
                {
                    user.PhoneNumber = row["PhoneNumber"].ToString();
                }


                if (!row["RoleID"].ToString().Equals(String.Empty))
                {
                    user.RoleID = Convert.ToInt32(row["RoleID"].ToString());
                }
                if (!row["StatusID"].ToString().Equals(String.Empty))
                {
                    user.StatusID = Convert.ToInt32(row["StatusID"].ToString());
                }
                if (!row["PictureID"].ToString().Equals(String.Empty))
                {
                    user.PictureID = Convert.ToInt32(row["PictureID"].ToString());
                }

                UserList.Add(user);
            } //End foreach loop


            return UserList;
        }

        //
        public string ChangePassword(int UserID, string password, bool initial)
        {
            string result;
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("ChangePassword", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserID", UserID);
                    cmd.Parameters.AddWithValue("Password", password);
                    cmd.Parameters.AddWithValue("Initial", initial);

                    dbconnection.Open();
                    cmd.ExecuteNonQuery();
                    result = "Done";
                }
                catch (SqlException ex)
                {
                    result = ex.ToString();
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        //
        public string EditUser(Users NUser)
        {
            string result;
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("EditUserViaUserID", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("UserID", NUser.UserID);
                    cmd.Parameters.AddWithValue("UserName", NUser.UserName);
                    cmd.Parameters.AddWithValue("FirstName", NUser.FirstName);
                    cmd.Parameters.AddWithValue("LastName", NUser.LastName);
                    cmd.Parameters.AddWithValue("Email", NUser.Email);
                    cmd.Parameters.AddWithValue("Adress", NUser.Adress);
                    cmd.Parameters.AddWithValue("City", NUser.City);
                    cmd.Parameters.AddWithValue("State", NUser.State);
                    cmd.Parameters.AddWithValue("ZipCode", NUser.ZipCode);
                    cmd.Parameters.AddWithValue("PhoneNumber", NUser.PhoneNumber);
                    cmd.Parameters.AddWithValue("RoleID", NUser.RoleID);
                    cmd.Parameters.AddWithValue("StatusID", NUser.StatusID);

                    dbconnection.Open();
                    cmd.ExecuteNonQuery();
                    result = "Done";
                }
                catch (SqlException ex)
                {
                    result = ex.ToString();
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        //This function takes UserID, and finds the password associated with it, and then returns if it was found or not
        public Users GetPassword(string id)
        {

            Users result = new Users();
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("GetPassword", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserID", id);

                    dbconnection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //--Pass values individually because I only need the first row
                            if (!reader.IsDBNull(0)) result.UserID = Convert.ToInt32(reader[0].ToString());
                            if (!reader.IsDBNull(1)) result.Password = reader[1].ToString();
                            result.Ex = "Found";
                        }
                        else
                        {
                            result.Ex = "None";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    result.Ex = ex.ToString();
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }

        public string DeleteUser(string id)
        {
            string result;
            var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DeleteUser", dbconnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("UserID", id);

                    dbconnection.Open();
                    int ARows = cmd.ExecuteNonQuery();

                    if (ARows == 0) result = "None";
                    else result = "Done";
                }
                catch (SqlException ex)
                {
                    result = "Failed Connection " + ex.Message;
                }
                finally
                {
                    dbconnection.Close();
                    dbconnection.Dispose();
                }
            }

            return result;
        }


        //
        //public string InsertProfilePicture(int UserID, string fileName, string type)
        //{
        //    string result;
        //    var connectionFromConfiguration = WebConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        //    using (SqlConnection dbconnection = new SqlConnection(connectionFromConfiguration))
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand("InsertProfilePicture", dbconnection);
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;

        //            cmd.Parameters.AddWithValue("UserID", UserID);

        //            dbconnection.Open();
        //            cmd.ExecuteNonQuery();
        //            result = "Done";
        //        }
        //        catch (SqlException ex)
        //        {
        //            result = ex.ToString();
        //        }
        //        finally
        //        {
        //            dbconnection.Close();
        //            dbconnection.Dispose();
        //        }
        //    }

        //    return result;
        //}

    }
}