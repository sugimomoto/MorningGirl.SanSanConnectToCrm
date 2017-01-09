namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    /// <summary>
    /// APIマッピング
    /// </summary>
    public class SanSanApiSetting
    {
        /// <summary>
        /// SANSAN-API Key
        /// </summary>
        public string sancrm_apikey { get; set; }

        /// <summary>
        /// SANSAN-API 設定 プライマリフィールド
        /// </summary>
        public string sancrm_name { get; set; }
        
        /// <summary>
        /// ステータス
        /// </summary>
        public int statuscode { get; set; }

        /// <summary>
        /// ステータス表示名
        /// </summary>
        public string statuscodeODataCommunityDisplayV1FormattedValue { get; set; }
        
        /// <summary>
        /// SANSAN-API 設定 GUID
        /// </summary>
        public string sancrm_sansan_api_settingid { get; set; }

        /// <summary>
        /// 名刺情報マッピング：フィールド名
        /// </summary>
        public string _sancrm_bizcardmapping_valueMicrosoftDynamicsCRMassociatednavigationproperty { get; set; }

        /// <summary>
        /// 名刺情報マッピング：エンティティ名
        /// </summary>
        public string _sancrm_bizcardmapping_valueMicrosoftDynamicsCRMlookuplogicalname { get; set; }

        /// <summary>
        /// 名刺情報マッピング：プライマリフィールド名
        /// </summary>
        public string _sancrm_bizcardmapping_valueODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// 名刺情報マッピング：GUID
        /// </summary>
        public string _sancrm_bizcardmapping_value { get; set; }
    }
}