using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    /// <summary>
    /// AzureADからTokenを取得するためのClass
    /// </summary>
    class AzureAdConnect
    {
        /// <summary>
        /// ClientID
        /// </summary>
        private string _clientId { get; set; }

        /// <summary>
        /// resourceUrl Dynamics 365 Web API エンドポイントURLを指定
        /// https://***.api.crm7.dynamics.com/api/data/v8.2/
        /// </summary>
        private string _recourceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private UserCredential _userCredential { get; set; }

        /// <summary>
        /// 
        /// </summary>
        private const string _loginUrl = "https://login.windows.net/common";

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public AzureAdConnect(string clientId, string userName, string password, string resourceUrl)
        {
            this._clientId = clientId;
            this._recourceUrl = resourceUrl;
            this._userCredential = new UserCredential(userName, password);
        }

        /// <summary>
        /// grant_type=passwordでTokenを取得
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetAccessToken()
        {
            var authConetxt = new AuthenticationContext(_loginUrl);

            var result = await authConetxt.AcquireTokenAsync(this._recourceUrl,this._clientId, this._userCredential);
            
            return result.AccessToken;
        }
    }
}
