using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security;
using System.IO;
using System.Security.Cryptography;
using DataModels;
using MySql.Data.MySqlClient;

namespace SafeDropBoxDLL
{
    public class UserAccountManagerDAL : ConnectionManager
    {
        SqlConnection cxn;
        SqlCommand cmd;

        MySqlConnection myCxn;
        MySqlCommand myCmd;

        public string Utoken { get; set; }
        public string Usecret { get; set; }
        public string Email { get; set; }
        public string UserPass { get; set; }
        public bool Success { get; set; }
        public int UID { get; set; }


        public bool CreateUser(Users newUser)
        {
            bool userCreated = false;

            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spNewUser", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCmd.Parameters.Add("pFirstName", MySqlDbType.VarChar, 50).Value = newUser.FirstName;
                    myCmd.Parameters.Add("pSurname", MySqlDbType.VarChar, 50).Value = newUser.Surname;
                    myCmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 50).Value = newUser.Email;
                    myCmd.Parameters.Add("pUserPassword", MySqlDbType.VarChar, 256).Value = newUser.Password;
                    myCmd.Parameters.Add("pUserID", MySqlDbType.Int16).Direction = ParameterDirection.Output;

                    myCxn.Open();
                    myCmd.ExecuteNonQuery();
                    myCxn.Close();
                    
                    userCreated = true;
                }

                if (userCreated)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool UserLoginNew(Users currentUser)
        {
            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spUserLoginNew", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCxn.Open();
                    if (myCxn.State == ConnectionState.Open)
                    {
                        myCmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 50).Value = currentUser.Email;

                        MySqlDataReader myReader = myCmd.ExecuteReader();

                        while (myReader.Read())
                        {
                            string eMail = myReader["Email"].ToString();
                            string pass = myReader["UserPassword"].ToString();

                            if (eMail == currentUser.Email && pass == currentUser.Password)
                            {
                                Success = true;
                                break;
                            }
                            else
                                return false;
                        }

                        myReader.Close();
                        myCxn.Close();
                    }
                    else
                    {
                        return false;
                    }
                }
                return Success;
            }
        }

        public bool RememberMe(string uToken, string uSecret, string eMail)
        {
            MySqlConnection cxn;
            MySqlCommand cmd;

            using (cxn = new MySqlConnection(this.ConnectionString))
            {
                using (cmd = new MySqlCommand("spNewUserAccess", cxn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("pUserToken", MySqlDbType.VarChar, 100).Value = uToken;
                    cmd.Parameters.Add("pUserSecret", MySqlDbType.VarChar, 100).Value = uSecret;
                    cmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 50).Value = eMail;

                    cxn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    cxn.Close();

                    if (rows > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public string GetToken(string eMail)
        {

            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spGetDetails", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCxn.Open();
                    MySqlDataReader dReader = myCmd.ExecuteReader();

                    while (dReader.Read())
                    {
                        Utoken = dReader["UserToken"].ToString();
                        break;
                    }
                    dReader.Close();
                    myCxn.Close();
                }
            }
            if (Utoken != null)
            {
                return Utoken;
            }
            else
            {
                return string.Format("Error");
            }


        }


        public string GetSecret(string eMail)
        {
            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spGetDetails", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCxn.Open();
                    MySqlDataReader dReader = myCmd.ExecuteReader();

                    while (dReader.Read())
                    {
                        Usecret = dReader["UserSecret"].ToString();
                        break;
                    }
                    dReader.Close();
                    myCxn.Close();
                }
            }
            if (Usecret != null)
            {
                return Usecret;
            }
            else
            {
                return string.Format("Error");
            }

        }

        public int UserID(string eMail)
        {
            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spGetDetails", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCxn.Open();
                    MySqlDataReader dReader = myCmd.ExecuteReader();

                    while (dReader.Read())
                    {
                        string tempID = dReader["UserID"].ToString();
                        UID = int.Parse(tempID);
                        break;
                    }
                    dReader.Close();
                    myCxn.Close();
                }
            }
            return UID;
        }




        public bool InsertFile(string eMail, string nameOfFile)
        {
            

            using (myCxn = new MySqlConnection(this.ConnectionString))
            {
                using (myCmd = new MySqlCommand("spNewFile", myCxn))
                {
                    myCmd.CommandType = CommandType.StoredProcedure;

                    myCmd.Parameters.Add("fFileName", MySqlDbType.VarChar, 45).Value = nameOfFile;
                    myCmd.Parameters.Add("fFileEmail", MySqlDbType.VarChar, 100).Value = eMail;
                    myCmd.Parameters.Add("fFileID", MySqlDbType.Int16).Direction = ParameterDirection.Output;
                }
            }
            myCxn.Open();
            myCmd.ExecuteNonQuery();
            myCxn.Close();


            return true;
        }











        



    }
}
