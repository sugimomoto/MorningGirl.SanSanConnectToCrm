using System;

namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    /// <summary>
    /// SANSANユーザー情報マッピング
    /// </summary>
    public class SanSanUserMapping
    {
        /// <summary>
        /// SANSANユーザー情報マッピング：GUID
        /// </summary>
        public string sancrm_user_mappingid { get; set; }

        /// <summary>
        /// 対象CRMユーザー：エンティティ名
        /// </summary>
        public string _sancrm_crmuser_valueMicrosoftDynamicsCRMlookuplogicalname { get; set; }

        /// <summary>
        /// 対象CRMユーザー：プライマリフィールド
        /// </summary>
        public string _sancrm_crmuser_valueODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// 対象CRMユーザー：GUID
        /// </summary>
        public string _sancrm_crmuser_value { get; set; }

        /// <summary>
        /// ステータス：表示名
        /// </summary>
        public string statuscodeODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// ステータス：コード
        /// </summary>
        public int statuscode { get; set; }

        /// <summary>
        /// SANSAN-ID
        /// </summary>
        public string sancrm_sansanid { get; set; }

        /// <summary>
        /// SANSAN-API設定：フィールド名
        /// </summary>
        public string _sancrm_apisetting_valueMicrosoftDynamicsCRMassociatednavigationproperty { get; set; }

        /// <summary>
        /// SANSAN-API設定：エンティティ名
        /// </summary>
        public string _sancrm_apisetting_valueMicrosoftDynamicsCRMlookuplogicalname { get; set; }

        /// <summary>
        /// SANSAN-API設定：プライマリフィールド名
        /// </summary>
        public string _sancrm_apisetting_valueODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// SANSAN-API設定：GUID
        /// </summary>
        public string _sancrm_apisetting_value { get; set; }
    }
}
