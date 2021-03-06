﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(LocaleApp.WinPhone.Locale_WinPhone))]

namespace LocaleApp.WinPhone
{
    public class Locale_WinPhone : ILocale
    {
        /// <remarks>
        /// Not sure if we can cache this info rather than querying every time
        /// </remarks>
        public string GetCurrent()
        {
            var lang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            return lang;
        }

        public void SetLocale()
        {
            //throw new NotImplementedException();
        }
    }
}
