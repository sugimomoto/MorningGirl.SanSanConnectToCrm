using System;
using System.Web;

namespace MorningGirl.SanSanConnectToCrm.Model.Sansan
{
    /// <summary>
    /// 期間条件に対する機能を提供します
    /// </summary>
    public class BizCardCondition
    {
        #region Constance

        /// <summary>
        /// 名刺取得の上限数を定義します
        /// </summary>
        private const int LIMIT = 100;

        #endregion

        #region Field

        /// <summary>
        /// 呼ばれた回数を保持します
        /// </summary>
        private int calledCount = 0;

        #endregion

        #region Public Property
        
        /// <summary>
        /// 期間開始を提供／設定します
        /// </summary>
        private DateTime From { get; set; }

        /// <summary>
        /// 期間終了を提供／設定します
        /// </summary>
        private DateTime To { get; set; }
        #endregion

        #region Public Method

        /// <summary>
        /// 条件文字列に変換します
        /// </summary>
        /// <returns></returns>
        public string ToQueryString()
        {
            var parameters = HttpUtility.ParseQueryString(string.Empty);

            parameters["registeredFrom"] = this.From.ToString("s") + "Z";
            parameters["registeredTo"] = this.To.ToString("s") + "Z";

            parameters["offset"] = (calledCount * LIMIT).ToString();
            parameters["range"] = "all";
            calledCount++;

            return parameters.ToString();
        }

        #endregion
    }
}
