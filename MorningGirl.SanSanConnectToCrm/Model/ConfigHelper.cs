using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model
{
    public static class ConfigHelper
    {
        /// <summary>
        /// SANSANAPIを利用するためのエンドポイントを取得
        /// </summary>
        public static string SanSanEndpoint {
            get
            {
                return ConfigurationManager.AppSettings[""];
            }
        }
    }
}
