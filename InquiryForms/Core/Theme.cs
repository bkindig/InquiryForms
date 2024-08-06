using System;
using System.Collections.Specialized;
using System.Web;

namespace InquiryForms.Core
{
    public class Theme
    {       
        //public static string ThemeId()
        //{
        //    if (request == null && HttpContext.Current != null)
        //        request = HttpContext.Current.Request;

        //    if (request.QueryString.GetValues("Theme") != null)
        //        return NormalizeThemeName(request.QueryString.GetValues("Theme").GetValue(0).ToString());

        //    if (request.QueryString.GetValues("BrandCode") != null)
        //        return NormalizeThemeName(request.QueryString.GetValues("BrandCode").GetValue(0).ToString());

        //    return ThemeId(request == null ? null : request.ServerVariables);
        //}

        private static string NormalizeThemeName(string themeName)
        {
            //add any theme name variants here to pair down to one naming convention
            string? themeValue = themeName;
            themeValue = themeName?.Replace("-", "").ToLower() == "goodsam" ? "good-sam" : themeName;
            return themeValue;
        }
    }
}