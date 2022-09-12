using System;
using WAN5CP.Services;

namespace WAN5CP.Models.Views.Login
{
    public class LoginPerson:IEquatable<LoginPerson>
    {
        public string login { get; set; }
        public string password { get; set; }
        public string Hash { get; private set; } = "";

        public LoginPerson()
        {
            
        }

        public LoginPerson(string _log, string _pass)
        {
            login = _log;
            password = _pass;
        }

        private void GetH_Md5()
        {
            
        }

        public bool Equals(LoginPerson other) => 
            GetHashCode() == other.GetHashCode();
        

        public override bool Equals(object obj)
        {
            if (obj is LoginPerson person) return Equals(person);
            return false;
        }

        public override int GetHashCode() =>
            $"{login}{password}{Hash}".GetHashCode();

    }
}