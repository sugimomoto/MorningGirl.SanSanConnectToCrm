using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model.Sansan
{
    public class SanSanConnect
    {
        /// <summary>
        /// SANSANのアプリケーションID
        /// </summary>
        private string SansanApplicationID { get; set; }

        /// <summary>
        /// SANSANのユーザーごとに発行されるAPIKEY
        /// </summary>
        private string SansanApiKey { get; set; }
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SanSanConnect(string ApplicationId, string ApiKey)
        {
            this.SansanApiKey = ApiKey;
            this.SansanApplicationID = ApplicationId;
        }
        
        /// <summary>
        /// SANSANからデータを取得するクラス
        /// 100件以上取得対応
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        public List<BizCard> GetBusinessCard(BizCardCondition condition)
        {
            var bizCards = new List<BizCard>();

            var hasMore = true;
            
            while(hasMore)
            {
                var sansanApiResponse = GetSansanBizCardRespoinse(condition.ToQueryString());

                bizCards.AddRange(sansanApiResponse.data);

                hasMore = sansanApiResponse.hasMore;
            }

            return bizCards;
        }

        /// <summary>
        /// BizCardApi応答を取得します
        /// </summary>
        /// <param name="conditionString">条件文字列</param>
        /// <returns>BizCardApi応答</returns>
        private SanSanDataResponse GetSansanBizCardRespoinse(string conditionString)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Sansan-App-Id", this.SansanApplicationID);
                client.DefaultRequestHeaders.TryAddWithoutValidation("X-Sansan-Api-Key", this.SansanApiKey);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.GetAsync(string.Format("{0}?{1}", ConfigHelper.SanSanEndpoint, conditionString)).Result;

                return JsonConvert.DeserializeObject<SanSanDataResponse>(response.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
