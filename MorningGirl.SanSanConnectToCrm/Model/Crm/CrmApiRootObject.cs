using System;

namespace MorningGirl.SanSanConnectToCrm.Model.Crm
{
    class CrmApiRootObject
    {
        public string odatacontext { get; set; }
        public Type[] value { get; set; }
    }
}
