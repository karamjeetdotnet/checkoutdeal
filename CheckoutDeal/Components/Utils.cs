using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CheckoutDeal.Components
{
    public class Utils
    {
        public static string GetPathFromNameSpace(object obj, string ViewName)
        {
            try
            {
                string FullName = obj.GetType().FullName;
                string ControllerName = FullName.Split('.').LastOrDefault();
                if (!string.IsNullOrEmpty(ControllerName))
                    ControllerName = GetControllerName(ControllerName);

                FullName = GetControllerName(FullName);

                return "~/Views/" + string.Join("/", FullName.Split('.').Skip(2)) + ControllerName + "/" + ViewName + ".cshtml";
            }
            catch { }
            return ViewName;
        }

        private static string GetControllerName(string FullName)
        {
            try
            {
                int ControllerIndex = FullName.IndexOf("Controller");
                FullName = FullName.Substring(0, ControllerIndex);
            }
            catch { }
            return FullName;
        }
    }
}