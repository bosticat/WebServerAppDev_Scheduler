﻿using System.Web;
using System.Web.Mvc;

namespace WebServerAppDev_Scheduler
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
