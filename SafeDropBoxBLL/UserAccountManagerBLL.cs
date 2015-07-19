using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafeDropBoxDLL;
using DataModels;

namespace SafeDropBoxBLL
{
    public class UserAccountManagerBLL
    {
        UserAccountManagerDAL userDAL = new UserAccountManagerDAL();

        public bool InsertFile(string eMail, string nameOfFile)
        {
            return userDAL.InsertFile(eMail, nameOfFile);
        }

        public bool NewUser(Users newUser)
        {
            return userDAL.CreateUser(newUser);
        }

        public bool UserLogin(Users currentUser)
        {
            return userDAL.UserLoginNew(currentUser);
        }

        public bool RememberMe(string uSecret, string uToken, string eMail)
        {
            return userDAL.RememberMe(uSecret, uToken, eMail);
        }

        public string GetToken(string eMail)
        {
            return userDAL.GetToken(eMail);
        }

        public string GetSecret(string eMail)
        {
            return userDAL.GetSecret(eMail);
        }

    }
}
