﻿using System.Web;
using System.Web.Mvc;

namespace Week10Lab.Pinterest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
