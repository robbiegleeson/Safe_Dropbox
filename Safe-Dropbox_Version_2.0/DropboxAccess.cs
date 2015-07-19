using DropNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafeDropBoxBLL;
using DropNet.Models;

namespace Safe_Dropbox_Version_2._0
{
    public class DropboxAccess
    {
        public string UserToken { get; set; }
        public string UserSecret { get; set; }
        public string Email { get; set; }

        //appKey and secret to be placed in app.config
        string appKey = ConfigurationManager.AppSettings["appKey"];
        string appSecret = ConfigurationManager.AppSettings["appSecret"];

        public bool LinkDrpbox()
        {
            bool dropboxLink = false;

            Authenticate(
               url =>
               {
                   var proc = Process.Start("iexplore.exe", url);
                   proc.WaitForExit();
                   Authenticated(
                       () =>
                       {
                           dropboxLink = true;
                       },
                       exc => ShowException(exc));

               },
               ex => dropboxLink = false);

            if (dropboxLink)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private DropNetClient _Client;
        public DropNetClient Client
        {
            get
            {
                if (_Client == null)
                {
                    _Client = new DropNetClient(appKey, appSecret);

                    if (IsAuthenticated)
                    {
                        _Client.UserLogin = new UserLogin
                        {
                            Token = UserToken,
                            Secret = UserSecret
                        };
                    }
                    _Client.UseSandbox = true;
                }
                return _Client;
            }
        }

        public bool IsAuthenticated
        {
            get
            {
                return UserToken != null &&
                    UserSecret != null;
            }
        }

        public void Authenticate(Action<string> success, Action<Exception> failure)
        {
            Client.GetTokenAsync(userLogin =>
            {
                var url = Client.BuildAuthorizeUrl(userLogin);
                if (success != null) success(url);
            }, error =>
            {
                if (failure != null) failure(error);
            });
        }


        public void Authenticated(Action success, Action<Exception> failure)
        {
            Client.GetAccessTokenAsync((accessToken) =>
            {
                UserToken = accessToken.Token;
                UserSecret = accessToken.Secret;

                UserAccountManagerBLL accBll = new UserAccountManagerBLL();
                accBll.RememberMe(UserToken, UserSecret, Email);

                if (success != null) success();
            },
            (error) =>
            {
                if (failure != null) failure(error);
            });

        }

        private void ShowException(Exception ex)
        {
            string error = ex.ToString();
        }
    }
}
