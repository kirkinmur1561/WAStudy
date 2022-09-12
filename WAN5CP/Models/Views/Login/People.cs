using System;
using System.Collections.Generic;
using System.Linq;

namespace WAN5CP.Models.Views.Login
{
    public static class People
    {
        private static List<LoginPerson> ListLP = new List<LoginPerson>()
        {
            new LoginPerson("_admin","123321")            
        };

        public static IEnumerable<LoginPerson> _lp => ListLP.AsEnumerable();

        public static bool Content(LoginPerson lp) =>
            ListLP.Contains(lp);

    }
}