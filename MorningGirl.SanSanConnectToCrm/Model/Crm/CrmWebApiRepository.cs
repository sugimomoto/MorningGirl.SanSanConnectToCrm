using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    /// <summary>
    /// CRM WEB API の基本操作を提供するクラス
    /// </summary>
    public class CrmWebApiRepository
    {
        /// <summary>
        /// Access Token
        /// </summary>
        private string _token { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="token"></param>
        public CrmWebApiRepository(string token)
        {
            this._token = token;
        }
        
        /// <summary>
        /// CRMから複数レコード取得
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityName"></param>
        /// <param name="select"></param>
        /// <param name="filter"></param>
        /// <returns></returns>
        public List<T> RetrieveMlutiple<T>(string entityName, string select, string filter)
        {
            var retrun = new List<T>();

            return retrun;
        }

        /// <summary>
        /// CRMから1レコード取得
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityName"></param>
        /// <param name="guid"></param>
        /// <returns></returns>
        public T Retrieve<T>(string entityName, Guid guid)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// CRMにレコード作成
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityName"></param>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        public Guid CreateEntity<T>(string entityName, T jsonObject)
        {
            var retrun = new Guid();

            return retrun;
        }

        /// <summary>
        /// CRMへレコードをアップデート
        /// </summary>
        /// <param name="recordId"></param>
        /// <param name="entityName"></param>
        /// <param name="jsonObject"></param>
        /// <returns></returns>
        public Guid UpdateEntity<T>(Guid recordId, string entityName, T jsonObject)
        {
            var retrun = new Guid();

            return retrun;
        }
        
        /// <summary>
        /// ロジカルネームを元にWebAPI用の複数形（LogicalCollectionName）を取得するメソッド
        /// </summary>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        public string GetLogicalCollectionName(string logicalName)
        {
            return "";
        }



    }
}
