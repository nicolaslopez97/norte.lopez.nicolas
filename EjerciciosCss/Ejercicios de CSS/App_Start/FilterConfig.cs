﻿using System.Web;
using System.Web.Mvc;

namespace Ejercicios_de_CSS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
