using Newtonsoft.Json;

namespace MorningGirl.SanSanConnectToCrm.Model.Sansan
{
    public class BizCard
    {
        /// <summary>
        /// 名刺ID
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }

        /// <summary>
        /// 人物ID
        /// </summary>
        [JsonProperty("personId")]
        public string PersonId { get; set; }

        /// <summary>
        /// 名刺交換日
        /// </summary>
        /// <remarks>“YYYY‒MM-DD” 形式</remarks>
        [JsonProperty("exchangeDate")]
        public string ExchangeDate { get; set; }

        /// <summary>
        /// 名刺登録日時
        /// </summary>
        /// <remarks>"YYYY‒MM‒DDThh:mm:ssTZD" 形式</remarks>
        [JsonProperty("registerdDate")]
        public string RegisterdDate { get; set; }

        /// <summary>
        /// 所有者を表すユーザオブジェクト
        /// </summary>
        [JsonProperty("owner")]
        public SansanUser Owner { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// 姓カナ
        /// </summary>
        [JsonProperty("lastNameReading")]
        public string LastNameReading { get; set; }

        /// <summary>
        /// 名カナ
        /// </summary>
        [JsonProperty("firstNameReading")]
        public string FirstNameReading { get; set; }

        /// <summary>
        /// 部署名
        /// </summary>
        [JsonProperty("departmentName")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 役職名
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// メールアドレス
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 携帯番号
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 会社名
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 郵便番号
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// 都道府県
        /// </summary>
        [JsonProperty("prefecture")]
        public string Prefecture { get; set; }

        /// <summary>
        /// 市区町村
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 番地
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// ビル名
        /// </summary>
        [JsonProperty("building")]
        public string Building { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        [JsonProperty("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// FAX番号
        /// </summary>
        [JsonProperty("fax")]
        public string Fax { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

    }
}
