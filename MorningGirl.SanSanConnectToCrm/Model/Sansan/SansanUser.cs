using Newtonsoft.Json;

namespace MorningGirl.SanSanConnectToCrm.Model.Sansan
{
    /// <summary>
    /// SansanのUserを表すモデル
    /// </summary>
    public class SansanUser
    {
        /// <summary>
        /// ユーザID
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// ユーザ名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
