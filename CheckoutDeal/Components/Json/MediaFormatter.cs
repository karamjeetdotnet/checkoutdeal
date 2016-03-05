using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Mvc;

namespace CheckoutDeal.Components.Json
{
    public class MediaTypeParser : JsonMediaTypeFormatter
    {
        public MediaTypeParser() : base()
        {
            RequiredMemberSelector = new RequiredMemberHelper();
        }
    }

    public class RequiredMemberHelper: IRequiredMemberSelector
    {

        public bool IsRequiredMember(System.Reflection.MemberInfo member)
        {
            return false;
        }
    }
    
}