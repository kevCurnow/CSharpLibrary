﻿using System.Web;
using System.Web.Mvc;

namespace _0._19_GuessingGameRebuild
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
