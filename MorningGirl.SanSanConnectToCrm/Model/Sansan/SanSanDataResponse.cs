using Newtonsoft.Json;
using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningGirl.SanSanConnectToCrm.Model.Sansan
{
    public class SanSanDataResponse
    {
        /// <summary>
        /// 100件以上の名刺存在可否
        /// </summary>
        public bool hasMore { get; set; }

        /// <summary>
        /// 名刺データコレクション
        /// </summary>
        public BizCard[] data { get; set; }
    }
}
