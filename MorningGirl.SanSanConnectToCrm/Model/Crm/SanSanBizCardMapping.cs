using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    /// <summary>
    /// 名刺情報マッピングクラス
    /// </summary>
    class SanSanBizCardMapping
    {
        /// <summary>
        /// 対象エンティティ名
        /// </summary>
        public string sancrm_target_entity { get; set; }

        /// <summary>
        /// ステータス：表示名
        /// </summary>
        public string statuscodeODataCommunityDisplayV1FormattedValue { get; set; }

        /// <summary>
        /// ステータス：コード
        /// </summary>
        public int statuscode { get; set; }

        /// <summary>
        /// メールアドレス
        /// </summary>
        public string sancrm_email { get; set; }

        /// <summary>
        /// FAX
        /// </summary>
        public string sancrm_fax { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string sancrm_tel { get; set; }

        /// <summary>
        /// 名刺交換日時
        /// </summary>
        public string sancrm_exchangedate { get; set; }

        /// <summary>
        /// 名刺登録日時
        /// </summary>
        public string sancrm_registered { get; set; }

        /// <summary>
        /// 役職
        /// </summary>
        public string sancrm_title { get; set; }

        /// <summary>
        /// 番地
        /// </summary>
        public string sancrm_street { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string sancrm_lastname { get; set; }

        /// <summary>
        /// 会社名
        /// </summary>
        public string sancrm_companyname { get; set; }

        /// <summary>
        /// 市区町村
        /// </summary>
        public string sancrm_city { get; set; }

        /// <summary>
        /// 名刺ID
        /// </summary>
        public string sancrm_id { get; set; }

        /// <summary>
        /// 都道府県
        /// </summary>
        public string sancrm_prefecture { get; set; }

        /// <summary>
        /// 部署名
        /// </summary>
        public string sancrm_departmentname { get; set; }

        /// <summary>
        /// ビル名
        /// </summary>
        public string sancrm_building { get; set; }
        
        /// <summary>
        /// 携帯電話
        /// </summary>
        public string sancrm_mobile { get; set; }

        /// <summary>
        /// GUID
        /// </summary>
        public string sancrm_bizcard_mappingid { get; set; }

        /// <summary>
        /// 名かな
        /// </summary>
        public string sancrm_firstnamereading { get; set; }

        /// <summary>
        /// 人物ID
        /// </summary>
        public string sancrm_personid { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        public string sancrm_firstname { get; set; }

        /// <summary>
        /// マッピング名
        /// </summary>
        public string sancrm_mapping_name { get; set; }

        /// <summary>
        /// URL
        /// </summary>
        public string sancrm_url { get; set; }

        /// <summary>
        /// 姓かな
        /// </summary>
        public string sancrm_lastnamereading { get; set; }

        /// <summary>
        /// 郵便番号
        /// </summary>
        public string sancrm_postalcode { get; set; }
    }
}
